using System.Linq;
using System.Threading.Tasks;
using Expotec2021.Api.Models;
using Expotec2021.Infra.Data.context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Expotec2021.Api.Controllerr
{   

    [Route("api/{controller}")]
    [ApiController]
    public class TarefasController: Controller
    {

        private readonly Context _context;
        
        public TarefasController(Context context)
        {
            _context = context;
        }


        [HttpGet("{idUser}")]
        public async Task<IActionResult> Get(string idUser)
        {
            var launchs = await _context.launchs.Where(c => c.ApplicationUserId == idUser).ToListAsync();
            return Ok(launchs);
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<Curtidas>> UpdatePost(int id)
        {
            var post =  await _context.posts.FindAsync(id);
            post.Likes += 1;
            await _context.SaveChangesAsync();

            var retorno = new Curtidas{ CurtidaDTO = post.Likes };
            return Ok(retorno);
        }
        [HttpPut("apiTarefas/{id}")]
        public async Task<IActionResult> UpdateTareta(int id)
        {
            var tarefa =  await _context.listTasks.FindAsync(id);


            if(tarefa.Check == true)
            {
                tarefa.Check = false;
                _context.listTasks.Update(tarefa);
                await _context.SaveChangesAsync();
                return Ok(tarefa);

            }else if(tarefa.Check == false)
            {
                tarefa.Check = true;
                _context.listTasks.Update(tarefa);
                await _context.SaveChangesAsync();
                return Ok(tarefa);
            
            }
            return NotFound();
        }
    }
}
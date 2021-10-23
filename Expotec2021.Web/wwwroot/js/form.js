// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//select form

const loginForm = document.querySelector('#login-form');
const registerForm = document.querySelector('#register-form');


const containerForm = document.querySelector('.form-container');

//select links


const registerUrl = document.querySelector('#login-form .link');
const LoginUrl = document.querySelector('#register-form .link');

registerUrl.addEventListener('click', ()=>{
    loginForm.classList.remove('active');
    setTimeout(() => {
        setTimeout(()=> {
            registerForm.classList.add('active');
        },500)
    }, 100);
    console.log("ta pegando script")
})

LoginUrl.addEventListener('click', ()=>{
    registerForm.classList.remove('active');
    setTimeout(() => {
        setTimeout(()=> {
            loginForm.classList.add('active');
        },500)
    }, 100);
})
import { addPartials } from "../util.js";

export async function registerPage(){
    await addPartials(this);
    this.partial('/templates/user/registerPage.hbs');
}

export async function loginPage(){
    await addPartials(this);
    this.partial('/templates/user/loginPage.hbs');
}

export async function postRegister(context){
   const {email, password, rePass} = context.params;
   if(email.length = 0 | password.length = 0 | )

}
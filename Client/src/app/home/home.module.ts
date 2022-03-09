import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

import { CreateAccountComponent } from './create-account/create-account.component';


import { UserPageComponent } from './user-page/user-page.component';

@NgModule({
  declarations: [

    LoginComponent,
    RegistrationComponent,

    CreateAccountComponent,


    UserPageComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: []
})
export class HomeModule { }

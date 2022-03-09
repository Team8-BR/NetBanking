import { NgModule } from '@angular/core';



import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

import { CreateAccountComponent } from './create-account/create-account.component';


import { UserPageComponent } from './user-page/user-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [

    LoginComponent,
    RegistrationComponent,
    HomePageComponent,
    CreateAccountComponent,


    UserPageComponent
  ],
  imports: [RouterModule
    
  ],
  providers: [],
  bootstrap: [],
  exports : [HomePageComponent]
})
export class NetBankingModule { }

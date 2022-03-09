import { NgModule } from '@angular/core';



import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

import { CreateAccountComponent } from './create-account/create-account.component';


import { UserPageComponent } from './user-page/user-page.component';
import { HomePageComponent } from './home-page/home-page.component';
import { RouterModule } from '@angular/router';
import { NetBankingRoutingModule } from './net-banking-routing.module';



@NgModule({
  declarations: [
    
    LoginComponent,
    RegistrationComponent,
    HomePageComponent,
    CreateAccountComponent,


    UserPageComponent
  ],
  imports: [RouterModule,NetBankingRoutingModule
    
  ],
  providers: [],
  bootstrap: [HomePageComponent],
  exports : [HomePageComponent,LoginComponent,]
})
export class NetBankingModule { }

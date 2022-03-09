import { NgModule } from '@angular/core';



import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

import { CreateAccountComponent } from './create-account/create-account.component';


import { HomePageComponent } from './home-page/home-page.component';
import { RouterModule } from '@angular/router';
import { NetBankingRoutingModule } from './net-banking-routing.module';
import { UserPageModule } from './user-page/user-page.module';



@NgModule({
  declarations: [
    
    LoginComponent,
    RegistrationComponent,
    HomePageComponent,
    CreateAccountComponent,


    
  ],
  imports: [RouterModule,NetBankingRoutingModule,UserPageModule
    
  ],
  providers: [],
  bootstrap: [],
  exports : [LoginComponent]
})
export class NetBankingModule { }

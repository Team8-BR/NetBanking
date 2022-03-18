import { NgModule } from '@angular/core';



import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';

import { CreateAccountComponent } from './create-account/create-account.component';


import { HomePageComponent } from './home-page/home-page.component';
import { RouterModule } from '@angular/router';
import { NetBankingRoutingModule } from './net-banking-routing.module';
import { UserPageModule } from './user-page/user-page.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AdminNavbarComponent } from './admin/admin-navbar/admin-navbar.component';
import { HttpClientModule } from '@angular/common/http';
import { AccountService } from './services/account.service';
import { CommonModule } from '@angular/common';





@NgModule({
  declarations: [
    
    LoginComponent,
    RegistrationComponent,
    HomePageComponent,
    CreateAccountComponent,

    AdminNavbarComponent,


    
  ],
  imports: [RouterModule,NetBankingRoutingModule,UserPageModule,FormsModule,ReactiveFormsModule,HttpClientModule,CommonModule
    
  ],
  providers: [AccountService],
  bootstrap: [],
  exports : [HomePageComponent]
})
export class NetBankingModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NetBankingModule } from './net-banking/net-banking.module';



@NgModule({
  declarations: [
    AppComponent
    
  
  ],
  imports: [
    BrowserModule,NetBankingModule,RouterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

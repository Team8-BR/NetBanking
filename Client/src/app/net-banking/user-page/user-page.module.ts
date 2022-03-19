import { NgModule } from '@angular/core';
import { AccountStatementComponent } from './account-statement/account-statement.component';
import { FundTransferComponent } from './fund-transfer/fund-transfer.component';
import { AccountDetailsComponent } from './account-details/account-details.component';
import { RouterModule } from '@angular/router';
import { UserPageComponent } from './user-page.component';
import { NavbarComponent } from './navbar/navbar.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [
      UserPageComponent,
    AccountStatementComponent,
    FundTransferComponent,
    AccountDetailsComponent,
    NavbarComponent,

 
  ],
  imports: [RouterModule,ReactiveFormsModule,CommonModule
   
  ],
  providers: [],
  exports : [UserPageComponent,FundTransferComponent]
 
})
export class UserPageModule { }

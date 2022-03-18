import { NgModule } from '@angular/core';
import { AccountStatementComponent } from './account-statement/account-statement.component';
import { FundTransferComponent } from './fund-transfer/fund-transfer.component';
import { AccountDetailsComponent } from './account-details/account-details.component';
import { RouterModule } from '@angular/router';
import { UserPageComponent } from './user-page.component';
import { NavbarComponent } from './navbar/navbar.component';



@NgModule({
  declarations: [
      UserPageComponent,
    AccountStatementComponent,
    FundTransferComponent,
    AccountDetailsComponent,
    NavbarComponent,

 
  ],
  imports: [RouterModule
   
  ],
  providers: [],
  exports : [UserPageComponent]
 
})
export class UserPageModule { }

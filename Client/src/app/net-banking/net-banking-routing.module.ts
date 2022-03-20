import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AdminProfileComponent } from "./admin/admin-profile/admin-profile.component";
import { AdminComponent } from "./admin/admin.component";
import { RequestedAccountDetailsComponent } from "./admin/requested-account-details/requested-account-details.component";
import { RequestedAccountComponent } from "./admin/requested-account/requested-account.component";
import { RespondedAccountsComponent } from "./admin/responded-accounts/responded-accounts.component";
import { CreateAccountComponent } from "./create-account/create-account.component";
import { HomePageComponent } from "./home-page/home-page.component";
import { LoginComponent } from "./login/login.component";
import { RegistrationComponent } from "./registration/registration.component";
import { AccountDetailsComponent } from "./user-page/account-details/account-details.component";
import { AccountStatementComponent } from "./user-page/account-statement/account-statement.component";
import { AccountSummaryComponent } from "./user-page/account-summary/account-summary.component";
import { FundTransferComponent } from "./user-page/fund-transfer/fund-transfer.component";
import { UserPageComponent } from "./user-page/user-page.component";


const AppRoutes : Routes = [
    {path : '', component : HomePageComponent, pathMatch : "full" },
    
   
    {path : 'login', component : LoginComponent },
    {path : 'register', component : RegistrationComponent},
    {path : 'CreateAccount', component : CreateAccountComponent},
    {path : 'user/:customerId', component : UserPageComponent, 
        children : 
        [
            {path : 'statement/:customerId', component : AccountStatementComponent},
            {path : 'profile/:customerId', component : AccountDetailsComponent},
            {path : 'transaction/:customerId', component : FundTransferComponent},
            {path : 'summary/:customerId', component : AccountSummaryComponent}
        ]},
    {path : 'admin', component : AdminComponent , 
        children : 
        [
            {path : 'reqaccounts', component : RequestedAccountComponent},
            {path : 'reqaccount/:customerId', component : RequestedAccountDetailsComponent},
            {path : 'profile', component : AdminProfileComponent},
            {path : 'resaccounts', component : RespondedAccountsComponent},
        ]},
   
   
    // admin/reqaccounts
]



@NgModule({
    imports : [ RouterModule.forRoot(AppRoutes)],
    exports : [RouterModule]
})
export class NetBankingRoutingModule{}
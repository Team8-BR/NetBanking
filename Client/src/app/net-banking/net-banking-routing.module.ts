import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { AdminComponent } from "./admin/admin.component";
import { CreateAccountComponent } from "./create-account/create-account.component";
import { HomePageComponent } from "./home-page/home-page.component";
import { LoginComponent } from "./login/login.component";
import { RegistrationComponent } from "./registration/registration.component";
import { AccountDetailsComponent } from "./user-page/account-details/account-details.component";
import { AccountStatementComponent } from "./user-page/account-statement/account-statement.component";
import { FundTransferComponent } from "./user-page/fund-transfer/fund-transfer.component";
import { UserPageComponent } from "./user-page/user-page.component";


const AppRoutes : Routes = [
    {path : '', component : HomePageComponent, pathMatch : "full" },
    
   
    {path : 'login', component : LoginComponent },
    {path : 'register', component : RegistrationComponent},
    {path : 'CreateAccount', component : CreateAccountComponent},
    {path : 'user', component : UserPageComponent, 
        children : 
        [
            {path : 'statement', component : AccountStatementComponent},
            {path : 'profile', component : AccountDetailsComponent},
            {path : 'transaction', component : FundTransferComponent}
        ]},
    {path : 'admin', component : AdminComponent},
    
]



@NgModule({
    imports : [ RouterModule.forRoot(AppRoutes)],
    exports : [RouterModule]
})
export class NetBankingRoutingModule{}
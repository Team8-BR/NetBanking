import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CreateAccountComponent } from "./create-account/create-account.component";
import { HomePageComponent } from "./home-page/home-page.component";
import { LoginComponent } from "./login/login.component";
import { RegistrationComponent } from "./registration/registration.component";

const AppRoutes : Routes = [
    {path : '', component : HomePageComponent},
    {path : 'Login', component : LoginComponent},
    {path : 'Register', component : RegistrationComponent},
    {path : 'CreateAccount', component : CreateAccountComponent}    
]


@NgModule({
    imports : [ RouterModule.forRoot(AppRoutes)],
    exports : [RouterModule]
})
export class NetBankingRoutingModule{}
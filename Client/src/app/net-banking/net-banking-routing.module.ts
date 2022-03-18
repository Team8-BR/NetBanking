import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { CreateAccountComponent } from "./create-account/create-account.component";
import { HomePageComponent } from "./home-page/home-page.component";
import { LoginComponent } from "./login/login.component";
import { RegistrationComponent } from "./registration/registration.component";
import { UserPageComponent } from "./user-page/user-page.component";


const AppRoutes : Routes = [
    {path : '', component : HomePageComponent},
    {path : 'login', component : LoginComponent },
    {path : 'register', component : RegistrationComponent},
    {path : 'CreateAccount', component : CreateAccountComponent},
    {path : 'Dashboard', component : UserPageComponent,outlet : "home"}
]



@NgModule({
    imports : [ RouterModule.forRoot(AppRoutes)],
    exports : [RouterModule]
})
export class NetBankingRoutingModule{}
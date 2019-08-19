import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthenticationComponent } from './views/authentication/authentication.component';
import { ClientsComponent } from './views/clients/clients.component';
import { InsurancepolicyComponent } from './views/insurancepolicy/insurancepolicy.component';


const routes: Routes = [
  {path:'auth', component: AuthenticationComponent},
  {path:'clients', component: ClientsComponent},
  {path:'insurancepolicy', component: InsurancepolicyComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

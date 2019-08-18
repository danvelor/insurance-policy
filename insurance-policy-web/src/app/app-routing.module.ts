import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthenticationComponent } from './views/authentication/authentication.component';
import { ClientsComponent } from './views/clients/clients.component';


const routes: Routes = [
  {path:'auth', component: AuthenticationComponent},
  {path:'clients', component: ClientsComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

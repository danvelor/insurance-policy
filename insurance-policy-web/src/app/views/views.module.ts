import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthenticationComponent } from './authentication/authentication.component';
import { AngularMaterialModule } from '../modules/angularmaterial/angularmaterial.module';
import { FlexLayoutModule } from '@angular/flex-layout';
import { HttpClientModule } from '@angular/common/http';
import { ReactiveFormsModule, FormsModule } from '@angular/forms';
import { ClientsComponent } from './clients/clients.component';
import { InsurancepolicyComponent } from './insurancepolicy/insurancepolicy.component';
import { ClientdetailComponent } from './clientdetail/clientdetail.component';


@NgModule({
  declarations: [AuthenticationComponent, ClientsComponent, InsurancepolicyComponent, ClientdetailComponent],
  imports: [
    CommonModule,
    AngularMaterialModule,
    FlexLayoutModule ,
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
  ]
})
export class ViewsModule { }

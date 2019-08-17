import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthenticationComponent } from './authentication/authentication.component';
import { AngularMaterialModule } from '../modules/angularmaterial/angularmaterial.module';
import { FlexLayoutModule } from '@angular/flex-layout';


@NgModule({
  declarations: [AuthenticationComponent],
  imports: [
    CommonModule,
    AngularMaterialModule,
    FlexLayoutModule 
  ]
})
export class ViewsModule { }

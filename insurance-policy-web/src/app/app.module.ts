import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AngularMaterialModule } from './modules/angularmaterial/angularmaterial.module';
import { ViewsModule } from './views/views.module';
import { DataProvider } from './providers/data.provider';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    AngularMaterialModule,
    ViewsModule
  ],
  providers: [DataProvider],
  bootstrap: [AppComponent]
})
export class AppModule { }

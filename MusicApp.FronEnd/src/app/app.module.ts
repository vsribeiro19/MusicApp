import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from '../app/login/login.component';
import { EsqueceuASenhaComponent } from './login/esqueceu-a-senha/esqueceu-a-senha.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    EsqueceuASenhaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

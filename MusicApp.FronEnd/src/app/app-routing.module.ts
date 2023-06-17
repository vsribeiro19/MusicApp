import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from '../app/login/login.component';
import { EsqueceuASenhaComponent } from './login/esqueceu-a-senha/esqueceu-a-senha.component';

const routes: Routes = [
  {
    path: 'login', component: LoginComponent
  },
  {
    path: 'nova-senha', component: EsqueceuASenhaComponent
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

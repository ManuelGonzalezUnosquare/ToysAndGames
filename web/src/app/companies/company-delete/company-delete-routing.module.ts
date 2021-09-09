import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {CompanyDeleteComponent} from './company-delete/company-delete.component';

const routes: Routes = [
  {path:'', component:CompanyDeleteComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CompanyDeleteRoutingModule { }

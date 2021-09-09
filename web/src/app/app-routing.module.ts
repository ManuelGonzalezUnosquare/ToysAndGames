import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [

  {path: 'companies', loadChildren:()=> import('./companies/companies-list/companies-list.module').then(m=> m.CompaniesListModule)},
  {path: 'company/:guid', loadChildren:()=> import('./companies/company-details/company-details.module').then(m=> m.CompanyDetailsModule)},
  {path: 'company', loadChildren:()=> import('./companies/company-details/company-details.module').then(m=> m.CompanyDetailsModule)},
  {path: 'company/:guid/delete', loadChildren:()=> import('./companies/company-delete/company-delete.module').then(m=> m.CompanyDeleteModule)},
  {
    path:'',
    redirectTo:'companies',
    pathMatch:'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

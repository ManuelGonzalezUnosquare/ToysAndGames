import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WorkInProgressComponent } from './shared/pages/work-in-progress/work-in-progress.component';

const routes: Routes = [

  { path: 'companies', loadChildren: () => import('./companies/companies-list/companies-list.module').then(m => m.CompaniesListModule) },
  { path: 'company', loadChildren: () => import('./companies/company-details/company-details.module').then(m => m.CompanyDetailsModule) },
  { path: 'company/:guid', loadChildren: () => import('./companies/company-details/company-details.module').then(m => m.CompanyDetailsModule) },
  { path: 'company/:guid/delete', loadChildren: () => import('./companies/company-delete/company-delete.module').then(m => m.CompanyDeleteModule) },

  { path: '', loadChildren: () => import('./products/product-list/product-list.module').then(m => m.ProductListModule) },
  { path: 'product', loadChildren: () => import('./products/product-details/product-details-routing.module').then(m => m.ProductDetailsRoutingModule) },
  { path: 'product/:guid', loadChildren: () => import('./products/product-details/product-details-routing.module').then(m => m.ProductDetailsRoutingModule) },
  { path: 'product/:guid/delete', loadChildren: () => import('./products/product-delete/product-delete-routing.module').then(m => m.ProductDeleteRoutingModule) },
  { path: '404', component: WorkInProgressComponent },
  { path: '**', redirectTo: '404' },
  {
    path: '',
    redirectTo: '',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

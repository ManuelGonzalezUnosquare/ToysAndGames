import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CompanyDeleteRoutingModule } from './company-delete-routing.module';
import { CompanyDeleteComponent } from './company-delete/company-delete.component';


@NgModule({
  declarations: [
    CompanyDeleteComponent
  ],
  imports: [
    CommonModule,
    CompanyDeleteRoutingModule
  ]
})
export class CompanyDeleteModule { }

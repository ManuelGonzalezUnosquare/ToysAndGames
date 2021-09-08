import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CompaniesListRoutingModule } from './companies-list-routing.module';
import { CompaniesListComponent } from './companies-list/companies-list.component';
import { MaterialModule } from 'src/app/material/material.module';

@NgModule({
  declarations: [
    CompaniesListComponent
  ],
  imports: [
    CommonModule,
    CompaniesListRoutingModule,
    MaterialModule
  ]
})
export class CompaniesListModule { }

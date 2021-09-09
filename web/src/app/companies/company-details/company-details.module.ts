import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CompanyDetailsRoutingModule } from './company-details-routing.module';
import { CompanyDetailsComponent } from './company-details/company-details.component';
import {MaterialModule} from 'src/app/material/material.module';


@NgModule({
  declarations: [
    CompanyDetailsComponent
  ],
  imports: [
    CommonModule,
    CompanyDetailsRoutingModule,
    MaterialModule
  ]
})
export class CompanyDetailsModule { }

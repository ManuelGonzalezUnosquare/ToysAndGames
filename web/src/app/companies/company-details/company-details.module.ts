import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CompanyDetailsRoutingModule } from './company-details-routing.module';
import { CompanyDetailsComponent } from './company-details/company-details.component';
import { MaterialModule } from 'src/app/material/material.module';
import { SharedModule } from 'src/app/shared/shared.module';


@NgModule({
  declarations: [
    CompanyDetailsComponent
  ],
  imports: [
    CommonModule,
    CompanyDetailsRoutingModule,
    MaterialModule,
    SharedModule
  ]
})
export class CompanyDetailsModule { }

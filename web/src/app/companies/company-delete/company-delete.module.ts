import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CompanyDeleteRoutingModule } from './company-delete-routing.module';
import { CompanyDeleteComponent } from './company-delete/company-delete.component';
import {MaterialModule} from 'src/app/material/material.module';
import {SharedModule} from 'src/app/shared/shared.module';


@NgModule({
  declarations: [
    CompanyDeleteComponent
  ],
  imports: [
    CommonModule,
    CompanyDeleteRoutingModule,
    SharedModule,
    MaterialModule
  ]
})
export class CompanyDeleteModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductListRoutingModule } from './product-list-routing.module';
import { ProductListComponent } from './product-list/product-list.component';
import { MaterialModule } from 'src/app/material/material.module';
import { IvyCarouselModule } from 'angular-responsive-carousel';
import {SharedModule} from 'src/app/shared/shared.module';
import { ProductFormComponent } from './product-form/product-form.component';


@NgModule({
  declarations: [
    ProductListComponent,
    ProductFormComponent
  ],
  imports: [
    CommonModule,
    ProductListRoutingModule,
    MaterialModule,
    IvyCarouselModule,
    SharedModule
  ]
})
export class ProductListModule { }

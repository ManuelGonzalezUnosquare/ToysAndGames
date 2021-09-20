import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductDetailsRoutingModule } from './product-details-routing.module';
import { MaterialModule } from 'src/app/material/material.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { ProductDetailsComponent } from './product-details/product-details.component';


@NgModule({
  declarations: [
    ProductDetailsComponent
  ],
  imports: [
    CommonModule,
    ProductDetailsRoutingModule,
    MaterialModule,
    SharedModule
  ]
})
export class ProductDetailsModule { }

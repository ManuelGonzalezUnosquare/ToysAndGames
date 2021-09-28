import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductFormRoutingModule } from './product-form-routing.module';
import { ProductFormComponent } from './product-form/product-form.component';
import { MaterialModule } from 'src/app/material/material.module';
import { SharedModule } from 'src/app/shared/shared.module';

@NgModule({
  declarations: [ProductFormComponent],
  imports: [CommonModule, ProductFormRoutingModule, MaterialModule, SharedModule],
})
export class ProductFormModule {}

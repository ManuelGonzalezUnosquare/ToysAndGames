import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {MatTableModule} from '@angular/material/table';
import {MatToolbarModule} from '@angular/material/toolbar';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatIconModule} from '@angular/material/icon';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    MatTableModule,
    MatPaginatorModule, 
    MatToolbarModule,
    MatIconModule
  ],
  exports:[
    MatTableModule,
    MatPaginatorModule,
    MatToolbarModule,
    MatIconModule
  ]
})
export class MaterialModule { }

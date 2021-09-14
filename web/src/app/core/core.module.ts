import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {HttpClientModule} from '@angular/common/http';
import {LoadingSpinnerModule} from './loading-spinner/loading-spinner.module';

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    HttpClientModule,
    LoadingSpinnerModule
  ],
  exports:[
    LoadingSpinnerModule
  ],
  providers:[
    HttpClientModule
  ]
})
export class CoreModule { }

import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MaterialModule} from './material/material.module';
import {HttpClientModule, HTTP_INTERCEPTORS} from '@angular/common/http';
import {LoadingSpinnerService} from './core/loading-spinner/loading-spinner.service';
import {BusyHttpRequestInterceptor} from './core/interceptors/busy-http-request.interceptor';
import {CoreModule} from './core/core.module';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    HttpClientModule,
    CoreModule
  ],
  providers:[

    LoadingSpinnerService,
    {
      provide: HTTP_INTERCEPTORS, useClass: BusyHttpRequestInterceptor, multi:true
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }


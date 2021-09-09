
import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpResponse
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { tap } from 'rxjs/internal/operators/tap';
import {LoadingSpinnerService} from '../loading-spinner/loading-spinner.service';

@Injectable()
export class BusyHttpRequestInterceptor implements HttpInterceptor {

  constructor(private spinnerService: LoadingSpinnerService) {
  }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
  this.spinnerService.show();
   return next.handle(request).pipe(
     tap((event: HttpEvent<any>) => {
       if (event instanceof HttpResponse) {
         this.spinnerService.hide();
       }
     }, (err: any) => {
       this.spinnerService.hide();
     }));
  }
}

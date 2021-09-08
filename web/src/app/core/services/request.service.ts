
import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import {ReturnListModel, ReturnModel} from '../models/responses';

@Injectable({
  providedIn: 'root'
})
export class RequestService {

  constructor(private httpClient: HttpClient) { }

  private objectToQueryParameter(obj: any): HttpParams {
    let params: HttpParams = new HttpParams();
    for (const key in obj) {
      if (obj.hasOwnProperty(key)) {
        const element = obj[key];
        params = params.set(key, element);
      }
    }
    return params;
  }
  private getHeaders():HttpHeaders{
    return new HttpHeaders();
  }
  private getUrl(url: string): string {
    return environment.baseUrl + url;
  }

  public get<T>(url: string): Observable<ReturnModel<T>> {
    return this.httpClient.get<ReturnModel<T>>(this.getUrl(url), { headers : this.getHeaders()}).pipe(map(res => res));
  }

  public getList<T>(url: string): Observable<ReturnListModel<T>> {
    return this.httpClient.get<ReturnListModel<T>>(this.getUrl(url), { headers:this.getHeaders() }).pipe(map(res => res));
  }
  public getListWithParams<T>(url: string, queryModel: any): Observable<ReturnListModel<T>> {
    return this.httpClient.get<ReturnListModel<T>>(this.getUrl(url),
      { headers:this.getHeaders(), params: this.objectToQueryParameter(queryModel) }).pipe(map(res => res));
  }

}

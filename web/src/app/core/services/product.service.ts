import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from '../models/dbModels';
import { ReturnListModel, ReturnModel } from '../models/responses';
import { BaseSearchCriteria } from '../models/searchCriteria';
import { RequestService } from './request.service';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  API = 'product';
  constructor(private reqService: RequestService) {}

  getAll(search: BaseSearchCriteria): Observable<ReturnListModel<Product>> {
    return this.reqService.getListWithParams<Product>(this.API, search);
  }

  getByGuid(guid: string): Observable<ReturnModel<Product>> {
    return this.reqService.get<Product>(this.API + guid);
  }
  post(name: string) {
    return this.reqService.post(this.API, name);
  }
  put(model: Product): Observable<ReturnModel<Product>> {
    return this.reqService.putWithModel(this.API, model);
  }
  delete(guid: string, isPermanent: boolean) {
    return this.reqService.deleteWithParams(this.API, { guid, isPermanent });
  }
}

import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Product } from 'src/app/core/models/dbModels';
import { ReturnListModel, ReturnModel } from 'src/app/core/models/responses';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { RequestService } from 'src/app/core/services';

@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private API = 'product';
  constructor(private requestService: RequestService) { }

  getAll(search: BaseSearchCriteria): Observable<ReturnListModel<Product>> {
    return this.requestService.getListWithParams<Product>(this.API, search);
  }

  getByGuid(guid: string): Observable<ReturnModel<Product>> {
    return this.requestService.get<Product>(`${this.API}/${guid}`);
  }
  postCreateCompany(name: string) {
    return this.requestService.post(this.API, name);
  }
  putUpdateCompany(model: Product): Observable<ReturnModel<Product>> {
    return this.requestService.putWithModel(this.API, model);
  }
  delete(guid: string, isPermanent: boolean) {
    return this.requestService.deleteWithParams(this.API, { guid, isPermanent });
  }
}

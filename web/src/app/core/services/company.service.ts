import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {Company} from '../models/dbModels';
import {ReturnListModel, ReturnModel} from '../models/responses';
import {BaseSearchCriteria} from '../models/searchCriteria';
import {RequestService} from './request.service';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {
  constructor(private reqService: RequestService) { }

  getAll(search: BaseSearchCriteria): Observable<ReturnListModel<Company>> {
    return this.reqService.getListWithParams<Company>('company', search);
  }

  getByGuid(guid: string): Observable<ReturnModel<Company>> {
    return this.reqService.get<Company>('company/' + guid);
  }
  postCreateCompany(name: string) {
    return this.reqService.post('Company', name);
  }
  putUpdateCompany(model: Company): Observable<ReturnModel<Company>> {
    return this.reqService.putWithModel('company', model);
  }
  delete(guid: string, isPermanent: boolean) {
    return this.reqService.deleteWithParams('company', { guid, isPermanent });
  }

}

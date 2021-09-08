import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {Company} from 'src/app/core/models/dbModels';
import {ReturnListModel} from 'src/app/core/models/responses';
import {BaseSearchCriteria} from 'src/app/core/models/searchCriteria';
import {RequestService} from 'src/app/core/services';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(private requestService: RequestService) { }

  getAll(search: BaseSearchCriteria):Observable<ReturnListModel<Company>>{
    return this.requestService.getListWithParams<Company>('company',search);
  }
}

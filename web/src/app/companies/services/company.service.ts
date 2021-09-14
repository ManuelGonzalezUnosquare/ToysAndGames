import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Company } from 'src/app/core/models/dbModels';
import { ReturnListModel, ReturnModel } from 'src/app/core/models/responses';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import { RequestService } from 'src/app/core/services';

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

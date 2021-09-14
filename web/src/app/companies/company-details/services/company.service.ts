import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Company } from 'src/app/core/models/dbModels';
import { ReturnModel } from 'src/app/core/models/responses';
import { RequestService } from 'src/app/core/services';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(private reqService: RequestService) { }

  getByGuid(guid: string): Observable<ReturnModel<Company>> {
    return this.reqService.get<Company>('company/' + guid);
  }
  postCreateCompany(name: string) {
    return this.reqService.post('Company', name);
  }
  putUpdateCompany(model: Company): Observable<ReturnModel<Company>> {
    return this.reqService.putWithModel('company', model);
  }
}

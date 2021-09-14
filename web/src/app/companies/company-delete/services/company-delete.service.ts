import { Injectable } from '@angular/core';
import {Observable} from 'rxjs';
import {Company} from 'src/app/core/models/dbModels';
import {ReturnModel} from 'src/app/core/models/responses';
import {RequestService} from 'src/app/core/services';

@Injectable({
  providedIn: 'root'
})
export class CompanyDeleteService {

  constructor(private requestService: RequestService) { }

  getByGuid(guid: string): Observable<ReturnModel<Company>> {
    return this.requestService.get<Company>('company/' + guid);
  }
  delete(guid:string, isPermanent:boolean){
    return this.requestService.deleteWithParams('company', {guid,isPermanent});
  }


}

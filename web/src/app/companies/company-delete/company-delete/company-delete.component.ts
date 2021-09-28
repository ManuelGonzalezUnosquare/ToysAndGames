import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Company } from 'src/app/core/models/dbModels';
import {CompanyService} from 'src/app/core/services';

@Component({
  selector: 'app-company-delete',
  templateUrl: './company-delete.component.html',
  styleUrls: ['./company-delete.component.scss'],
})
export class CompanyDeleteComponent implements OnInit {
  company: Company;
  deleteTextInfo = {
    permanent: 'esto es permanente',
    noPermanent: 'esto NO ES PERMANENTE',
  };
  isPermanent = false;
  constructor(private activatedRoute: ActivatedRoute, private router: Router, private service: CompanyService) {
    let guid = this.activatedRoute.snapshot.params.guid;
    if (!guid) {
      this.router.navigate(['/companies']);
    } else {
      this.getCompanyByGuid(guid);
    }
  }

  ngOnInit(): void {}
  getCompanyByGuid(guid: string): void {
    this.service.getByGuid(guid).subscribe(
      (data) => {
        if (data.isSuccess) {
          this.company = data.model;
          console.log('data', this.company);
        } else {
          console.log(data.error);
        }
      },
      (error) => {
        console.log('error', error);
      }
    );
  }
  delete(): void {
    this.service.delete(this.company.guid, this.isPermanent).subscribe(
      (data) => {
        console.log('Data', data);
        this.router.navigate(['/companies']);
      },
      (error) => {
        console.log('error', error);
      }
    );
  }
  cancel(): void {
    this.router.navigate(['/companies']);
  }
}

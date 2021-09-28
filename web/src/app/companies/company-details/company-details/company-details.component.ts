import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Company } from 'src/app/core/models/dbModels';
import {CompanyService} from 'src/app/core/services';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';

@Component({
  selector: 'app-company-details',
  templateUrl: './company-details.component.html',
  styleUrls: ['./company-details.component.scss'],
})
export class CompanyDetailsComponent implements OnInit {
  title = 'New Company';
  form: FormGroup;
  submitted: boolean;
  company: Company;
  isUpdate: boolean;
  constructor(
    private activatedRoute: ActivatedRoute,
    private formBuilder: FormBuilder,
    private companyService: CompanyService,
    private route: Router,
    private notificationService: NotificationBarService
  ) {
    let guid = this.activatedRoute.snapshot.params.guid;
    if (guid) {
      this.title = 'Edit Company';
      this.getCompanyByGuid(guid);
      this.isUpdate = true;
    }
  }
  get f(): any {
    return this.form.controls;
  }
  ngOnInit(): void {
    this.initializeForm();
  }
  getCompanyByGuid(guid: string) {
    this.companyService.getByGuid(guid).subscribe(
      (data) => {
        if (data.isSuccess) {
          this.initializeForm();
          this.form.controls.name.patchValue(data.model.name);
          this.company = data.model;
        }
      },
      (error) => {}
    );
  }
  initializeForm() {
    this.form = this.formBuilder.group({
      name: new FormControl(null, [Validators.required]),
    });
  }
  submit(): void {
    if (this.form.valid) {
      this.submitted = true;
      this.notificationService.closeSnackBar();
      let newValue = this.form.value;
      if (this.company) {
        newValue = { name: this.form.value.name, guid: this.company.guid };
      }
      if (!this.isUpdate) {
        this.post(newValue);
      } else {
        this.put(newValue);
      }
    } else {
      this.notificationService.openSnackBar("Looks like there's missing or invalid information.");
    }
  }
  post(newValue: any) {
    this.companyService.postCreateCompany(newValue).subscribe(
      (data) => {
        if (data.isSuccess) {
          this.route.navigate(['companies']);
        } else {
          this.notificationService.openSnackBar(data.error);
        }
      },
      (error) => {
        this.notificationService.openSnackBar(error.error);
      }
    );
  }
  put(newValue: any) {
    this.companyService.putUpdateCompany(newValue).subscribe(
      (data) => {
        if (data.isSuccess) {
          this.route.navigate(['companies']);
        } else {
          this.notificationService.openSnackBar(data.error);
        }
      },
      (error) => {
        this.notificationService.openSnackBar(error.error);
      }
    );
  }
}

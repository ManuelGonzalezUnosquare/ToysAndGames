import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Company } from 'src/app/core/models/dbModels';
import { ReturnListModel } from 'src/app/core/models/responses';
import { BaseSearchCriteria } from 'src/app/core/models/searchCriteria';
import {CompanyService, ProductService} from 'src/app/core/services';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';
import { ImageUploaderComponent } from 'src/app/shared/widgets/image-uploader/image-uploader.component';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.scss'],
})
export class ProductFormComponent implements OnInit {
  form: FormGroup;
  submitted: boolean;
  companyResults: Observable<Company[]>;
  companySearch = new BaseSearchCriteria();
  constructor(
    private formBuilder: FormBuilder,
    private notificationService: NotificationBarService,
    private dialog: MatDialog,
    private companyService: CompanyService,
    private productService: ProductService,
    private route: Router
  ) {}

  ngOnInit(): void {
    this.searchCompany('');
    this.initializeForm();
  }

  get f(): any {
    return this.form.controls;
  }

  initializeForm(): void {
    this.form = this.formBuilder.group({
      name: [null, [Validators.required]],
      description: [null],
      ageRestriction: [5, [Validators.required]],
      price: [1, [Validators.required]],
      pic: [null],
      picThumbnail: [null],
      companyGuid: [null, [Validators.required]],
    });
  }
  submit(): void {
    if (this.form.valid) {
      const submitModel = Object.assign({}, this.form.value);
      submitModel.companyGuid = submitModel.companyGuid.guid;
      this.productService.post(submitModel).subscribe(
        (data) => {
          if (data.isSuccess) {
            this.route.navigate(['/products']);
          } else {
            this.notificationService.openSnackBar(data.error);
          }
        },
        (error) => {
          this.notificationService.openSnackBar(error.message);
        }
      );
    }
  }
  openImageDialog(): void {
    const dialogRef = this.dialog.open(ImageUploaderComponent);
    dialogRef.afterClosed().subscribe((result) => {
      if (result) {
        this.form.controls.pic.patchValue(dialogRef.componentInstance.image.original.base64);
        this.form.controls.picThumbnail.patchValue(dialogRef.componentInstance.croppedImage);
      }
    });
  }
  searchCompany(value: any) {
    if (value.keyCode < 37 || value.keyCode > 40) {
      this.companySearch.hint = value.target.value;
      this.companyResults = this.companyService.getAll(this.companySearch).pipe(
        map((response: ReturnListModel<Company>) => {
          return response.model;
        })
      );
    }
  }
  displayFn(value?: Company) {
    return value ? value.name : undefined;
  }
}

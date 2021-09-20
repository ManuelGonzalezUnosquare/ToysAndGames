import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { NotificationBarService } from 'src/app/core/services/notification-bar.service';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.scss'],
})
export class ProductFormComponent implements OnInit {
  form: FormGroup;
  submitted:boolean;
  constructor(
    private formBuilder: FormBuilder,
    private notificationService: NotificationBarService
  ) {}

  ngOnInit(): void {
    this.initializeForm();
  }

  get f(): any {
    return this.form.controls;
  }

  initializeForm(): void {
    this.form = this.formBuilder.group({
      name: [null, [Validators.required]],
      description: [null],
      pic: [null],
    });
  }
  submit(): void {}
}

import { ModuleWithProviders, NgModule } from '@angular/core';
import {MaterialModule} from 'src/app/material/material.module';
import { LoadingSpinnerComponent } from './loading-spinner.component';
import {LoadingSpinnerService} from './loading-spinner.service';


@NgModule({
  declarations: [
    LoadingSpinnerComponent
  ],
  imports: [
  MaterialModule
  ],
  exports:[LoadingSpinnerComponent],
  providers:[LoadingSpinnerService]
})
export class LoadingSpinnerModule { 
  static forRoot(): ModuleWithProviders<Object>{
    return {
      ngModule: LoadingSpinnerModule,
      providers:[LoadingSpinnerService]
    }
  }
}

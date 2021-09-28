import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { MaterialModule } from '../material/material.module';
import { MenubarComponent } from './layout/menubar/menubar.component';
import { WorkInProgressComponent } from './pages/work-in-progress/work-in-progress.component';
import { RouterModule } from '@angular/router';
import { SearchComponent } from './widgets/search/search.component';
import { StopPropagationDirective } from './directives/stop-propagation.directive';
import { ImageUploaderComponent } from './widgets/image-uploader/image-uploader.component';
import { ImageCropperModule } from 'ngx-image-cropper';
import { FooterComponent } from './layout/footer/footer.component';
import { HomeSliderComponent } from './widgets/home-slider/home-slider.component';
import { IvyCarouselModule } from 'angular-responsive-carousel';
import { ProductViewerComponent } from './widgets/product-viewer/product-viewer.component';

@NgModule({
  declarations: [
    NavbarComponent,
    MenubarComponent,
    WorkInProgressComponent,
    SearchComponent,
    StopPropagationDirective,
    ImageUploaderComponent,
    FooterComponent,
    HomeSliderComponent,
    ProductViewerComponent,
  ],
  imports: [CommonModule, FormsModule, ReactiveFormsModule, MaterialModule, RouterModule, ImageCropperModule, IvyCarouselModule],
  exports: [
    FormsModule,
    ReactiveFormsModule,
    NavbarComponent,
    MenubarComponent,
    WorkInProgressComponent,
    SearchComponent,
    StopPropagationDirective,
    ImageUploaderComponent,
    HomeSliderComponent,
    FooterComponent,
    IvyCarouselModule,
    ProductViewerComponent,
  ],
})
export class SharedModule {}

import { Injectable } from '@angular/core';
import { MatSnackBar, MatSnackBarConfig, MatSnackBarHorizontalPosition, MatSnackBarRef, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';


@Injectable({
  providedIn: 'root'
})
export class NotificationBarService {
  private snackBarConfig: MatSnackBarConfig;
  private snackBarRef: MatSnackBarRef<any>;
  private horizontalPosition: MatSnackBarHorizontalPosition = 'center';
  private verticalPosition: MatSnackBarVerticalPosition = 'bottom';
  private snackBarAutoHide = '1500';
  constructor(private snackBar: MatSnackBar) { }

  openSnackBar(message: string) {
    this.snackBarConfig = new MatSnackBarConfig();
    this.snackBarConfig.horizontalPosition = this.horizontalPosition;
    this.snackBarConfig.verticalPosition = this.verticalPosition;
    this.snackBarConfig.panelClass = 'custom-snackbar';
    
    this.snackBarRef = this.snackBar.open(message, 'close', this.snackBarConfig);
  }
  closeSnackBar(){
    this.snackBar.dismiss();
  }
}

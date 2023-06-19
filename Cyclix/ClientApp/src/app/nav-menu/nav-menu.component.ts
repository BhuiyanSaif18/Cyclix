import { Component } from '@angular/core';
import { TranslateService } from '@ngx-translate/core';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  selectedLanguage: string = "en";

 
  constructor(private translateService: TranslateService) {
    this.translateService.setDefaultLang(this.selectedLanguage); 
    this.translateService.use(this.selectedLanguage); 
  }

  onLanguageChange() {
    this.translateService.use(this.selectedLanguage);
  }
}

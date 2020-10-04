import { Component, OnInit } from '@angular/core';
import { TextService } from './text.service';
import { Text as TextModel } from './text.model';

@Component({
    selector: 'app-text',
    templateUrl: './text.component.html',
    styleUrls: ['./text.component.scss']
})
export class TextComponent implements OnInit {

    text: string;
    wordsCount: number;

    constructor(private textService: TextService) { }

    ngOnInit(): void {
        this.text = 'Sample text from compoonent.';
    }

    getTextFromDb(): void {
        this.textService.fetchFromDb(1)
            .subscribe((text: TextModel) => {
                this.text = text.content;
            },
            error => console.error(error));
    }

    getTextFromFile(): void {
        this.textService.fetchFromFile(1)
            .subscribe((text: TextModel) => {
                this.text = text.content;
            },
            error => console.error(error));
    }

    countWords(): void {
        this.textService.countWords(this.text)
            .subscribe(result => this.wordsCount = result.wordsCount,
                error => console.error(error));
    }
}

class Mailbox {
    constructor(mailbox) {
        this.mailbox = [];
    }

    addMessage(subject, text) {
        this.mailbox.push({
            subject: subject,
            text: text
        });
        return this;
    }

    get messageCount() {
        return this.mailbox.length;
    }

    deleteAllMessages() {
        this.mailbox = [];
    }

    findBySubject(substr) {
        let result = [];
        for (let msg of this.mailbox) {
            if (msg.subject.includes(substr)) {
                result.push(msg);
            }
        }
        return result;
    }

    toString() {
        if (this.mailbox.length > 0) {
            let result = [];
            for (let msg of this.mailbox) {
                result.push(` * [${msg.subject}] ${msg.text}`)
            }
            return result.join(`\n`);
        }
        else {
            return ` * (empty mailbox)`
        }
    }
}



class EventEmitter {
    constructor() {
        this.subscription = {};
    }

    on(eventName, cb) {
        this.subscription[eventName] =
            (this.subscription[eventName] || []).concat([cb]);

        const cbIndex = this.subscription[eventName].length - 1;
        return () => {
            this.subscription[eventName] = [
                ...this.subscription[eventName].slice(0, cbIndex),
                ...this.subscription[eventName].slice(cbIndex + 1)
                ];
        };
    }

    once(eventName, cb) {
        const unsub = this.on(eventName, data => {
            cb(data);
            unsub();
        })
    }

    emit(eventName, data) {
        (this.subscription[eventName] || []).forEach(cb => {
            cb(data);
        });
    }
}


const emitter = new EventEmitter();
// const unsub = emitter.on('getData', console.log);
// emitter.on('getData', data => console.log(data));
// unsub();
emitter.on('getData', console.log);
emitter.on('getData', console.log);
// emitter.emit('getData', 'Testing...');
// console.log('-------');
emitter.once('getData', console.log);
emitter.emit('getData', 'Testing...');
emitter.emit('getData', 'Testing...');
// console.log('-------');
// emitter.emit('getData', 'Testing...');
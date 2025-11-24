module Popup

open Browser

let div = document.getElementById "main"
div.innerHTML <- "<p>Hello world from F#! Compiled with Fable.</p>"

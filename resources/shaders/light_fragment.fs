#version 330 core
out vec4 fragColor;

uniform vec3 FragColor;

void main() {

    fragColor = vec4(FragColor, 1.0);
}
#version 330 core
out vec4 fragColor;

in vec3 ourColor;
in vec2 texCoord;

uniform sampler2D texture_sampler;

void main() {
    fragColor = texture(texture_sampler, texCoord);
}
S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 16489
Date: 2017-06-13 14:03:04+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 4
      (SIGILL)
      si_code: 1
      illegal opcode
      si_addr: 0xb27eb64e

Register Information
r0   = 0xb8462c18, r1   = 0xb846f4a8
r2   = 0xb846f4a8, r3   = 0xb8462c18
r4   = 0xb3fdaa3c, r5   = 0xbe8e3484
r6   = 0x00000001, r7   = 0xbe8e3348
r8   = 0xbe8e3478, r9   = 0xb82d31f8
r10  = 0xbe8e3498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbe8e32ec
lr   = 0xb27eb5d5, pc   = 0xb27eb64e
cpsr = 0x40070030

Memory Information
MemTotal:   987012 KB
MemFree:     69164 KB
Buffers:     62488 KB
Cached:     226408 KB
VmPeak:      98668 KB
VmSize:      98664 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19560 KB
VmRSS:       19560 KB
VmData:      30212 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35772 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 16489 TID = 16489
16489 16494 16511 16512 

Maps Information
b139c000 b13a4000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13b6000 b1bb5000 rw-p [stack:16512]
b1bb5000 b1bb6000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1bc6000 b1bda000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bee000 b1bef000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bff000 b1c02000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c13000 b1c14000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c24000 b1c26000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c36000 b1c38000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c48000 b1c58000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c68000 b1c74000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c86000 b2485000 rw-p [stack:16511]
b27b6000 b27bd000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27d0000 b27d6000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27e6000 b2816000 r-xp /opt/usr/apps/org.example.client/bin/client
b295f000 b2a42000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a79000 b2aa1000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab3000 b32b2000 rw-p [stack:16494]
b32b2000 b32b4000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c4000 b32ce000 r-xp /lib/libnss_files-2.20-2014.11.so
b32df000 b32e8000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f9000 b330a000 r-xp /lib/libnsl-2.20-2014.11.so
b331d000 b3323000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3334000 b3335000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335d000 b3364000 r-xp /usr/lib/libminizip.so.1.0.0
b3374000 b3379000 r-xp /usr/lib/libstorage.so.0.1
b3389000 b33e8000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fe000 b3412000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b3422000 b3466000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3476000 b347e000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348e000 b34be000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34d1000 b358a000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359e000 b35f1000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b3602000 b361d000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362d000 b36ee000 r-xp /usr/lib/libprotobuf.so.9.0.1
b3701000 b3711000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3721000 b372e000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373f000 b3746000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3756000 b3797000 r-xp /usr/lib/libmdm.so.1.2.12
b37a7000 b37af000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37be000 b37ce000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ef000 b384f000 r-xp /usr/lib/libasound.so.2.0.0
b3861000 b3864000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3874000 b3877000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3887000 b388c000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b389c000 b389d000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38ad000 b38b8000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38cc000 b38d3000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e3000 b38e9000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f9000 b38fe000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390e000 b3929000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3939000 b3940000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3950000 b3953000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3964000 b3992000 r-xp /usr/lib/libidn.so.11.5.44
b39a2000 b39b8000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c9000 b39d3000 r-xp /usr/lib/libcares.so.2.1.0
b39e3000 b39ed000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fd000 b39ff000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0f000 b3a10000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a20000 b3a24000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a35000 b3a5d000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6e000 b3a97000 r-xp /usr/lib/libturbojpeg.so
b3ab7000 b3abd000 r-xp /usr/lib/libgif.so.4.1.6
b3acd000 b3b13000 r-xp /usr/lib/libcurl.so.4.3.0
b3b24000 b3b45000 r-xp /usr/lib/libexif.so.12.3.3
b3b60000 b3b75000 r-xp /usr/lib/libtts.so
b3b86000 b3b8e000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9e000 b3c64000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c84000 b3d7c000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d9b000 b3e69000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e80000 b3e82000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e92000 b3e98000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea8000 b3ecb000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3edc000 b3ede000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eee000 b3ef0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3f01000 b3f06000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1d000 b3f1f000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2f000 b3f36000 r-xp /usr/lib/libsensord-share.so
b3f46000 b3f5e000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6f000 b3f72000 r-xp /usr/lib/libXv.so.1.0.0
b3f82000 b3f87000 r-xp /usr/lib/libutilX.so.1.1.0
b3f97000 b3f9c000 r-xp /usr/lib/libappcore-common.so.1.1
b3fac000 b3fb3000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc6000 b3fca000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fdb000 b40b9000 r-xp /usr/lib/libCOREGL.so.4.0
b40d9000 b40dc000 r-xp /usr/lib/libuuid.so.1.3.0
b40ec000 b4103000 r-xp /usr/lib/libblkid.so.1.1.0
b4114000 b4116000 r-xp /usr/lib/libXau.so.6.0.0
b4126000 b416d000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417f000 b4185000 r-xp /usr/lib/libjson-c.so.2.0.1
b4196000 b419a000 r-xp /usr/lib/libogg.so.0.7.1
b41aa000 b41cc000 r-xp /usr/lib/libvorbis.so.0.4.3
b41dc000 b42c0000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42dc000 b42df000 r-xp /usr/lib/libEGL.so.1.4
b42f0000 b42f6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4306000 b4308000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4318000 b4325000 r-xp /usr/lib/libGLESv2.so.2.0
b4336000 b4398000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43ad000 b43c5000 r-xp /usr/lib/libmount.so.1.1.0
b43d7000 b43eb000 r-xp /usr/lib/libxcb.so.1.1.0
b43fb000 b4402000 r-xp /lib/libcrypt-2.20-2014.11.so
b443a000 b443c000 r-xp /usr/lib/libiri.so
b444c000 b4457000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4468000 b449e000 r-xp /usr/lib/libpulse.so.0.16.2
b44af000 b44f2000 r-xp /usr/lib/libsndfile.so.1.0.25
b4507000 b451c000 r-xp /lib/libexpat.so.1.5.2
b452e000 b45ec000 r-xp /usr/lib/libcairo.so.2.11200.14
b4600000 b4608000 r-xp /usr/lib/libdrm.so.2.4.0
b4618000 b461b000 r-xp /usr/lib/libdri2.so.0.0.0
b462b000 b4679000 r-xp /usr/lib/libssl.so.1.0.0
b468e000 b469a000 r-xp /usr/lib/libeeze.so.1.13.0
b46ab000 b46b4000 r-xp /usr/lib/libethumb.so.1.13.0
b46c4000 b46c7000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d7000 b488e000 r-xp /usr/lib/libcrypto.so.1.0.0
b5679000 b5682000 r-xp /usr/lib/libXi.so.6.1.0
b5692000 b5694000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a4000 b56a8000 r-xp /usr/lib/libXtst.so.6.1.0
b56b8000 b56be000 r-xp /usr/lib/libXrender.so.1.3.0
b56ce000 b56d4000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e4000 b56e6000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f7000 b56fa000 r-xp /usr/lib/libXfixes.so.3.1.0
b570a000 b5715000 r-xp /usr/lib/libXext.so.6.4.0
b5725000 b5727000 r-xp /usr/lib/libXdamage.so.1.1.0
b5737000 b5739000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5749000 b582b000 r-xp /usr/lib/libX11.so.6.3.0
b583f000 b5846000 r-xp /usr/lib/libXcursor.so.1.0.2
b5856000 b586e000 r-xp /usr/lib/libudev.so.1.6.0
b5870000 b5873000 r-xp /lib/libattr.so.1.1.0
b5883000 b58a3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a4000 b58a9000 r-xp /usr/lib/libffi.so.6.0.2
b58ba000 b58d2000 r-xp /lib/libz.so.1.2.8
b58e2000 b58e4000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f4000 b59c9000 r-xp /usr/lib/libxml2.so.2.9.2
b59de000 b5a79000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a95000 b5a98000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa8000 b5ac1000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5ad2000 b5ae3000 r-xp /lib/libresolv-2.20-2014.11.so
b5af7000 b5b71000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b86000 b5b88000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b98000 b5b9f000 r-xp /usr/lib/libembryo.so.1.13.0
b5baf000 b5bb9000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bca000 b5be2000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf3000 b5c16000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c37000 b5c4b000 r-xp /usr/lib/libector.so.1.13.0
b5c5c000 b5c74000 r-xp /usr/lib/liblua-5.1.so
b5c85000 b5cdc000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cf0000 b5d18000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d29000 b5d3c000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4d000 b5d87000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d98000 b5da6000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db6000 b5dbe000 r-xp /usr/lib/libtbm.so.1.0.0
b5dce000 b5ddb000 r-xp /usr/lib/libeio.so.1.13.0
b5deb000 b5ded000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfd000 b5e02000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e12000 b5e29000 r-xp /usr/lib/libefreet.so.1.13.0
b5e3b000 b5e5b000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e6b000 b5e8b000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8d000 b5e93000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea3000 b5eb4000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec5000 b5ecc000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5edc000 b5eeb000 r-xp /usr/lib/libeo.so.1.13.0
b5efc000 b5f0e000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1f000 b5f24000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f34000 b5f4d000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5d000 b5f7a000 r-xp /usr/lib/libeet.so.1.13.0
b5f93000 b5fdb000 r-xp /usr/lib/libeina.so.1.13.0
b5fec000 b5ffc000 r-xp /usr/lib/libefl.so.1.13.0
b600d000 b60f2000 r-xp /usr/lib/libicuuc.so.51.1
b610f000 b624f000 r-xp /usr/lib/libicui18n.so.51.1
b6266000 b629e000 r-xp /usr/lib/libecore_x.so.1.13.0
b62b0000 b62b3000 r-xp /lib/libcap.so.2.21
b62c3000 b62ec000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fd000 b6304000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6316000 b634d000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635e000 b6449000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b645c000 b64d5000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e7000 b64ec000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64fc000 b6506000 r-xp /usr/lib/libvconf.so.0.2.45
b6516000 b6518000 r-xp /usr/lib/libvasum.so.0.3.1
b6528000 b652a000 r-xp /usr/lib/libttrace.so.1.1
b653a000 b653d000 r-xp /usr/lib/libiniparser.so.0
b654d000 b6573000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6583000 b6588000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6599000 b65b0000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65c1000 b662c000 r-xp /lib/libm-2.20-2014.11.so
b663d000 b6643000 r-xp /lib/librt-2.20-2014.11.so
b6654000 b6661000 r-xp /usr/lib/libunwind.so.8.0.1
b6697000 b67bb000 r-xp /lib/libc-2.20-2014.11.so
b67d0000 b67e9000 r-xp /lib/libgcc_s-4.9.so.1
b67f9000 b68db000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68ec000 b6916000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6927000 b6963000 r-xp /usr/lib/libsystemd.so.0.4.0
b6965000 b69e8000 r-xp /usr/lib/libedje.so.1.13.0
b69fb000 b6a19000 r-xp /usr/lib/libecore.so.1.13.0
b6a39000 b6bc0000 r-xp /usr/lib/libevas.so.1.13.0
b6bf5000 b6c09000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1d000 b6e51000 r-xp /usr/lib/libelementary.so.1.13.0
b6e80000 b6e84000 r-xp /usr/lib/libsmack.so.1.0.0
b6e94000 b6e9b000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6eab000 b6ead000 r-xp /usr/lib/libdlog.so.0.0.0
b6ebd000 b6ec0000 r-xp /usr/lib/libbundle.so.0.1.22
b6ed0000 b6ed2000 r-xp /lib/libdl-2.20-2014.11.so
b6ee3000 b6efb000 r-xp /usr/lib/libaul.so.0.1.0
b6f0f000 b6f14000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f25000 b6f32000 r-xp /usr/lib/liblptcp.so
b6f44000 b6f48000 r-xp /usr/lib/libsys-assert.so
b6f59000 b6f79000 r-xp /lib/ld-2.20-2014.11.so
b6f8a000 b6f8f000 r-xp /usr/bin/launchpad-loader
b824a000 b848f000 rw-p [heap]
be8c3000 be8e4000 rw-p [stack]
End of Maps Information

Callstack Information (PID:16489)
Call Stack Count: 13
 0: $d.51 + 0x0 (0xb27eb64e) [/opt/usr/apps/org.example.client/bin/client] + 0x564e
 1: _ZN7MyLoginC2EP9Naviframe + 0x84 (0xb27eb5d5) [/opt/usr/apps/org.example.client/bin/client] + 0x55d5
 2: _ZN8MyWindow8onCreateEv + 0x118 (0xb27eb3a9) [/opt/usr/apps/org.example.client/bin/client] + 0x53a9
 3: _ZN6Window10app_createEPv + 0x72 (0xb28045cf) [/opt/usr/apps/org.example.client/bin/client] + 0x1e5cf
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb2804745) [/opt/usr/apps/org.example.client/bin/client] + 0x1e745
 5: (0xb3fc84f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6f12203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3fc8909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb2804acf) [/opt/usr/apps/org.example.client/bin/client] + 0x1eacf
 9: main + 0x40 (0xb27eb129) [/opt/usr/apps/org.example.client/bin/client] + 0x5129
10: (0xb6f8bbb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66ad4bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f8beb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
ng.weather-m-agent] 
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:03:01.644+0900 E/MESSAGE_PORT(16467): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 14:03:01.644+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:03:01.644+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:03:01.654+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:03:01.654+0900 E/MESSAGE_PORT(16467): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:03:01.654+0900 E/weather-common(16467): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:03:01.654+0900 E/weather-agent(16467): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:03:01.654+0900 E/weather-agent(16467): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:03:01.654+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:01.654+0900 I/MESSAGE_PORT(16467): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:03:01.674+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:01.704+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:01.704+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:01.704+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:01.704+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:01.704+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:01.714+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:01.714+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:03:01.774+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:03:01.774+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:01.774+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:01.774+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:01.784+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:1:LOCK
06-13 14:03:01.784+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:1 event_info:0
06-13 14:03:01.784+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:03:01.784+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:1 event_info:0
06-13 14:03:01.784+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [visible]
06-13 14:03:01.784+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10001:WIN_BECOME_VISIBLE
06-13 14:03:01.784+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10001 event_info:0
06-13 14:03:01.784+0900 W/INDICATOR(  665): main.c: _indicator_lock_status_cb(418) > LockState is Lock, but Lockscreen invisible state
06-13 14:03:01.784+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(59) > [_lock_state_timer_cb:59:E] ########## LOCK STATE SET : VCONFKEY_IDLE_LOCK ##########
06-13 14:03:01.784+0900 W/APP_CORE(  857): appcore-efl.c: __visibility_cb(989) > LCD status is off, skip the AE_RESUME event
06-13 14:03:01.784+0900 W/INDICATOR(  665): main.c: _indicator_lock_status_cb(413) > Hide Clock
06-13 14:03:01.784+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:03:01.794+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:03:01.794+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(179) > [_dbus_message_recv_cb:179:W] POST_LCD_OFF status 4 visibility(1)
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): event.c: _lcd_off_completed_cb(48) > [_lcd_off_completed_cb:48:W] Vconf LCD off
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30002:LCD_OFF
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:30002 event_info:0
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:6
06-13 14:03:01.794+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL PAUSE => PAUSE
06-13 14:03:01.964+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16099 pgid = 16099
06-13 14:03:01.964+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16099)
06-13 14:03:01.964+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16099.
06-13 14:03:01.974+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1643
06-13 14:03:01.994+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:01.994+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:01.994+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:01.994+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16099
06-13 14:03:01.994+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16099.
06-13 14:03:01.994+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16099
06-13 14:03:01.994+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16099
06-13 14:03:01.994+0900 E/RESOURCED(  667): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1644
06-13 14:03:02.655+0900 E/weather-agent(16467): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:03:02.655+0900 I/CAPI_APPFW_APPLICATION(16467): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:03:02.655+0900 E/weather-agent(16467): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:03:02.655+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:03:02.655+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:03:02.735+0900 I/UXT     (16489): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:02.785+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:03:02.785+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16467
06-13 14:03:02.785+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[16467] terminate event is forwarded
06-13 14:03:02.785+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:03:02.785+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 16467, ]
06-13 14:03:02.785+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:03:02.785+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:03:02.785+0900 I/Tizen::App( 1175): (512) > Not registered pid(16467)
06-13 14:03:02.785+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:03:02.785+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:03:02.785+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16467
06-13 14:03:02.795+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:03:02.795+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 16467.
06-13 14:03:02.795+0900 I/Tizen::System( 1175): (458) > org.tizen.system.deviced.display - CurrentBrightness (100)
06-13 14:03:03.155+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
06-13 14:03:03.155+0900 W/LOCKSCREEN(  857): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
06-13 14:03:03.155+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
06-13 14:03:03.155+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
06-13 14:03:03.155+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
06-13 14:03:03.155+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
06-13 14:03:03.155+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(195) > ""
06-13 14:03:03.165+0900 E/UXT     (  665): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 2:03
06-13 14:03:03.165+0900 I/INDICATOR(  665): clock.c: getTimeFormatted(176) > "time format : 오후 2:03"
06-13 14:03:03.165+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 2:03"
06-13 14:03:03.165+0900 W/INDICATOR(  665): clock.c: indicator_clock_changed_cb(272) > 
06-13 14:03:03.165+0900 I/INDICATOR(  665): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2147263912 Time: <font_size=31> </font_size> <font_size=31> 오후 2:03</font_size></font>"
06-13 14:03:03.165+0900 I/INDICATOR(  665): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
06-13 14:03:03.165+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
06-13 14:03:03.165+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:03:03.165+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:03:03.165+0900 E/INDICATOR(  665): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
06-13 14:03:03.165+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:03:03.165+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:03:03.165+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:03:03.165+0900 E/INDICATOR(  665): box.c: _update_icon(232) > (!list) -> _update_icon() return
06-13 14:03:03.165+0900 E/LOCKSCREEN(  857): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
06-13 14:03:03.396+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
06-13 14:03:03.396+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
06-13 14:03:03.396+0900 W/APP_CORE(  857): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
06-13 14:03:03.396+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: RESUME State: PAUSED
06-13 14:03:03.396+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:03:03.396+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
06-13 14:03:03.396+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
06-13 14:03:03.396+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:03:03.396+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
06-13 14:03:03.396+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 0
06-13 14:03:03.396+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 857
06-13 14:03:03.396+0900 I/AUL_AMD (  607): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
06-13 14:03:03.406+0900 W/AUL_AMD (  607): amd_launch.c: start_process(638) > child process: 16496
06-13 14:03:03.406+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:03.456+0900 W/AUL_AMD (  607): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 16496
06-13 14:03:03.456+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16496, appid: com.samsung.weather-m-agent
06-13 14:03:03.466+0900 I/Tizen::App( 1175): (499) > LaunchedApp(com.samsung.weather-m-agent)
06-13 14:03:03.466+0900 I/Tizen::App( 1175): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 16496.
06-13 14:03:03.476+0900 W/AUL     (  857): launch.c: app_request_to_launchpad(425) > request cmd(0) result(16496)
06-13 14:03:03.626+0900 E/weather-agent(16496): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
06-13 14:03:03.626+0900 E/weather-common(16496): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
06-13 14:03:03.626+0900 E/weather-agent(16496): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
06-13 14:03:03.626+0900 E/weather-common(16496): CityDBController.cpp: GetPrimaryKey(376) > [0;40;31mNo result : 101[0;m
06-13 14:03:03.636+0900 E/weather-common(16496): CityDBController.cpp: Select(265) > [0;40;31mNo result : 101[0;m
06-13 14:03:03.636+0900 E/weather-common(16496): DBController.cpp: SelectDataWithPrimaryKey(154) > [0;40;31m[SelectDataWithPrimaryKey(): 154] (!cityPtr) [return][0;m
06-13 14:03:03.636+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: ShareDisplayCityWeatherInfo(289) > [0;40;31mthere is no city[0;m
06-13 14:03:03.636+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: AddWeatherInfoToBundle(438) > [0;40;31m[AddWeatherInfoToBundle(): 438] (cityPtrVector->size() == 0) [return][0;m
06-13 14:03:03.636+0900 I/MESSAGE_PORT(16496): message-port.c: __initialize(872) > initialize
06-13 14:03:03.636+0900 I/MESSAGE_PORT(16496): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:03:03.666+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
06-13 14:03:03.666+0900 I/MESSAGE_PORT(  857): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
06-13 14:03:03.666+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
06-13 14:03:03.666+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:03.676+0900 E/MESSAGE_PORT(16496): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __message_port_send_message(972) > port exist check !!
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
06-13 14:03:03.676+0900 I/MESSAGE_PORT( 1324): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
06-13 14:03:03.676+0900 E/MESSAGE_PORT(16496): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 1[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: BundleGetString(565) > [0;40;31mFail to bundle_get_str : -126[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : [0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
06-13 14:03:03.676+0900 E/weather-common(16496): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : Off[0;m
06-13 14:03:03.676+0900 E/weather-agent(16496): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
06-13 14:03:03.676+0900 E/weather-agent(16496): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
06-13 14:03:03.676+0900 I/MESSAGE_PORT(16496): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
06-13 14:03:03.676+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:03.696+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:03.706+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17169912
06-13 14:03:03.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:03.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:03.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.746+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.746+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:03.756+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_update_cb(287) > received updating signal
06-13 14:03:03.806+0900 I/Tizen::System( 1175): (280) > The screen has been turned on.
06-13 14:03:03.806+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:03:03.806+0900 E/EFL     (  857): ecore_x<857> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17170017
06-13 14:03:03.816+0900 E/LOCKSCREEN(  857): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
06-13 14:03:03.816+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:03:03.816+0900 W/LOCKSCREEN(  857): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
06-13 14:03:03.826+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:03:03.836+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
06-13 14:03:03.836+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:03.836+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:03.846+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetCityPtrWithLocationId(77) > [0;40;31m[GetCityPtrWithLocationId(): 77] (!mCityPtrVector) [return][0;m
06-13 14:03:03.846+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetIndexOfDisplayCity(411) > [0;40;31m[GetIndexOfDisplayCity(): 411] (!cityPtr) [return][0;m
06-13 14:03:03.846+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.846+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.846+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.856+0900 E/weather-widget( 1324): WidgetMain.cpp: GetCityPtr(125) > [0;40;31m[GetCityPtr(): 125] (!mWeatherInfo) [return][0;m
06-13 14:03:03.856+0900 E/weather-widget( 1324): WidgetViewData.cpp: GetNumberOfCities(387) > [0;40;31m[GetNumberOfCities(): 387] (!mCityPtrVector) [return][0;m
06-13 14:03:03.856+0900 E/weather-widget( 1324): WidgetMain.cpp: ResumeWidgetInstance(585) > [0;40;31m[ResumeWidgetInstance(): 585] (widgetViewDataPtr->GetNumberOfCities() <= 0) [break][0;m
06-13 14:03:03.856+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
06-13 14:03:03.856+0900 I/CAPI_WIDGET_APPLICATION( 1324): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
06-13 14:03:03.856+0900 W/AUL     ( 1324): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1324, appid: com.samsung.weather-m-widget, status: fg
06-13 14:03:03.916+0900 E/cluster-home( 1167): cluster-data-list.cpp: GetDBoxID(1000) >  found id[1]
06-13 14:03:03.916+0900 W/cluster-view( 1167): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
06-13 14:03:04.136+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
06-13 14:03:04.136+0900 W/LOCKSCREEN(  857): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
06-13 14:03:04.136+0900 W/LOCKSCREEN(  857): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
06-13 14:03:04.136+0900 E/LOCKSCREEN(  857): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
06-13 14:03:04.136+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:03:04.136+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:03:04.136+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:03:04.136+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:03:04.136+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
06-13 14:03:04.146+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:04.146+0900 W/LOCKSCREEN(  857): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
06-13 14:03:04.146+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
06-13 14:03:04.146+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
06-13 14:03:04.146+0900 E/LOCKSCREEN(  857): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
06-13 14:03:04.146+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: PAUSE State: RUNNING
06-13 14:03:04.146+0900 I/CAPI_APPFW_APPLICATION(  857): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
06-13 14:03:04.146+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:03:04.146+0900 E/LOCKSCREEN(  857): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
06-13 14:03:04.146+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
06-13 14:03:04.146+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
06-13 14:03:04.146+0900 W/LOCKSCREEN(  857): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
06-13 14:03:04.146+0900 E/LOCKSCREEN(  857): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
06-13 14:03:04.156+0900 E/EFL     (  342): eo<342> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
06-13 14:03:04.156+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(857) status(4)
06-13 14:03:04.156+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(857)
06-13 14:03:04.156+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 857, appid: com.samsung.lockscreen, status: bg
06-13 14:03:04.156+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3328) > pid(1167) status(3)
06-13 14:03:04.156+0900 W/AUL_AMD (  607): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
06-13 14:03:04.156+0900 W/AUL_AMD (  607): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
06-13 14:03:04.156+0900 W/AUL     (  607): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(1167)
06-13 14:03:04.156+0900 W/AUL     (  607): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1167, appid: com.samsung.homescreen, status: fg
06-13 14:03:04.156+0900 I/APP_CORE( 1167): appcore-efl.c: __do_app(514) > [APP 1167] Event: RESUME State: PAUSED
06-13 14:03:04.156+0900 I/CAPI_APPFW_APPLICATION( 1167): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
06-13 14:03:04.156+0900 E/cluster-home( 1167): homescreen.cpp: OnResume(233) >  app resume
06-13 14:03:04.156+0900 I/APP_CORE(  857): appcore-efl.c: __do_app(514) > [APP 857] Event: MEM_FLUSH State: PAUSED
06-13 14:03:04.186+0900 I/Tizen::System( 1175): (259) > Active app [com.samsun], current [com.samsun] 
06-13 14:03:04.186+0900 I/Tizen::System( 1175): (273) > Current App[com.samsun] is already actived.
06-13 14:03:04.186+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 15
06-13 14:03:04.246+0900 W/LOCKSCREEN(  857): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
06-13 14:03:04.246+0900 E/LOCKSCREEN(  857): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
06-13 14:03:04.246+0900 E/LOCKSCREEN(  857): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
06-13 14:03:04.246+0900 W/LOCKSCREEN(  857): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
06-13 14:03:04.246+0900 W/LOCKSCREEN(  857): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
06-13 14:03:04.256+0900 E/LOCKSCREEN(  857): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
06-13 14:03:04.487+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17170689
06-13 14:03:04.537+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17170744
06-13 14:03:04.537+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:03:04.537+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:03:04.547+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:03:04.557+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:03:04.557+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:04.557+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:04.557+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:04.557+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:04.567+0900 I/abc     (16489): abc
06-13 14:03:04.567+0900 I/CAPI_APPFW_APPLICATION(16489): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:04.567+0900 I/CAPI_APPFW_APPLICATION(16489): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:04.597+0900 E/TBM     (16489): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:04.657+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16489, appid: org.example.client
06-13 14:03:04.657+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:04.667+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16489)
06-13 14:03:04.687+0900 E/weather-agent(16496): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
06-13 14:03:04.687+0900 I/CAPI_APPFW_APPLICATION(16496): service_app_main.c: service_app_exit(446) > service_app_exit
06-13 14:03:04.687+0900 E/weather-agent(16496): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
06-13 14:03:04.687+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 22
06-13 14:03:04.687+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(1201) > app status : 5
06-13 14:03:04.857+0900 W/AUL_AMD (  607): amd_request.c: __send_app_termination_signal(609) > send dead signal done
06-13 14:03:04.867+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16496
06-13 14:03:04.867+0900 I/Tizen::App( 1175): (243) > App[com.samsung.weather-m-agent] pid[16496] terminate event is forwarded
06-13 14:03:04.867+0900 I/Tizen::System( 1175): (256) > osp.accessorymanager.service provider is found.
06-13 14:03:04.867+0900 I/Tizen::System( 1175): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 16496, ]
06-13 14:03:04.867+0900 I/Tizen::System( 1175): (256) > osp.system.service provider is found.
06-13 14:03:04.867+0900 I/Tizen::App( 1175): (506) > TerminatedApp(com.samsung.weather-m-agent)
06-13 14:03:04.867+0900 I/Tizen::App( 1175): (512) > Not registered pid(16496)
06-13 14:03:04.867+0900 I/Tizen::System( 1175): (246) > Terminated app [com.samsung.weather-m-agent]
06-13 14:03:04.867+0900 I/Tizen::Io( 1175): (729) > Entry not found
06-13 14:03:04.867+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16496
06-13 14:03:04.867+0900 I/Tizen::System( 1175): (157) > change brightness system value.
06-13 14:03:04.867+0900 I/Tizen::App( 1175): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 16496.
06-13 14:03:05.678+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 16489 pgid = 16489
06-13 14:03:05.678+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(143) > dead_pid(16489)
06-13 14:03:05.678+0900 E/Tizen::App( 1175): (703) > Cannot acquire app for 16489.
06-13 14:03:05.718+0900 I/AUL_PAD ( 1377): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
06-13 14:03:05.718+0900 I/AUL_PAD ( 1377): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
06-13 14:03:05.718+0900 E/AUL_PAD ( 1377): launchpad.c: main(698) > error reading sigchld info
06-13 14:03:05.718+0900 I/ESD     (  898): esd_main.c: __esd_app_dead_handler(1773) > pid: 16489
06-13 14:03:05.718+0900 I/Tizen::App( 1175): (753) > [E_OBJ_NOT_FOUND] Cannot acquire app from pid 16489.
06-13 14:03:05.718+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 16489
06-13 14:03:05.718+0900 W/AUL_AMD (  607): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 16489
06-13 14:03:06.549+0900 I/UXT     (16525): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
06-13 14:03:07.650+0900 W/AUL_AMD (  607): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
06-13 14:03:07.840+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=17174057
06-13 14:03:07.940+0900 E/EFL     ( 1167): ecore_x<1167> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=17174156
06-13 14:03:07.950+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(396) > request cmd(1) to(org.example.client)
06-13 14:03:07.950+0900 W/AUL_AMD (  607): amd_request.c: __request_handler(906) > __request_handler: 1
06-13 14:03:07.950+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(2508) > caller pid : 1167
06-13 14:03:07.960+0900 E/RESOURCED(  667): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 6
06-13 14:03:07.960+0900 E/RESOURCED(  667): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
06-13 14:03:07.960+0900 W/AUL_AMD (  607): amd_launch.c: _start_app(3052) > pad pid(-5)
06-13 14:03:07.960+0900 W/AUL_PAD ( 1377): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
06-13 14:03:07.960+0900 W/AUL_PAD ( 1377): launchpad.c: __send_result_to_caller(267) > Check app launching
06-13 14:03:07.970+0900 I/abc     (16525): abc
06-13 14:03:07.980+0900 I/CAPI_APPFW_APPLICATION(16525): app_main.c: ui_app_main(789) > app_efl_main
06-13 14:03:07.980+0900 I/CAPI_APPFW_APPLICATION(16525): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
06-13 14:03:08.010+0900 E/TBM     (16525): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
06-13 14:03:08.060+0900 W/AUL     (  607): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 16525, appid: org.example.client
06-13 14:03:08.060+0900 E/AUL     (  607): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
06-13 14:03:08.060+0900 W/AUL     ( 1167): launch.c: app_request_to_launchpad(425) > request cmd(1) result(16525)
06-13 14:03:08.240+0900 W/CRASH_MANAGER(16473): worker.c: worker_job(1199) > 0416489636c69149733018

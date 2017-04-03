S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 1532
Date: 2017-04-02 23:39:09+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 1532, uid 5000)

Register Information
r0   = 0xb8186cf0, r1   = 0xb33753ae
r2   = 0x80000000, r3   = 0x00000069
r4   = 0xb5a24065, r5   = 0x00000000
r6   = 0x00000001, r7   = 0xbef52340
r8   = 0xbef52478, r9   = 0xb7fee650
r10  = 0xbef52498, fp   = 0x00000004
ip   = 0x00000000, sp   = 0xbef522f0
lr   = 0x64656d2f, pc   = 0xb337301c
cpsr = 0xa0030030

Memory Information
MemTotal:   987012 KB
MemFree:    214580 KB
Buffers:     41240 KB
Cached:     315216 KB
VmPeak:      98428 KB
VmSize:      98424 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       19440 KB
VmRSS:       19440 KB
VmData:      30108 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35644 KB
VmPTE:          72 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 1532 TID = 1532
1532 1540 7404 7405 

Maps Information
b13b9000 b13c1000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b13d3000 b1bd2000 rw-p [stack:7405]
b1bd2000 b1bd3000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1be3000 b1bf7000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1c0b000 b1c0c000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1c1c000 b1c1f000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1c30000 b1c31000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1c41000 b1c43000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c53000 b1c55000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c65000 b1c75000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c85000 b1c91000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1ca3000 b24a2000 rw-p [stack:7404]
b27d3000 b27da000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27ed000 b27f3000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b2803000 b2813000 r-xp /opt/usr/apps/org.example.client/bin/client
b295c000 b2a3f000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a76000 b2a9e000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2ab0000 b32af000 rw-p [stack:1540]
b32af000 b32b1000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b32c1000 b32cb000 r-xp /lib/libnss_files-2.20-2014.11.so
b32dc000 b32e5000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32f6000 b3307000 r-xp /lib/libnsl-2.20-2014.11.so
b331a000 b3320000 r-xp /lib/libnss_compat-2.20-2014.11.so
b3331000 b3332000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b335a000 b3361000 r-xp /usr/lib/libminizip.so.1.0.0
b3371000 b3376000 r-xp /usr/lib/libstorage.so.0.1
b3386000 b33e5000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33fb000 b340f000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b341f000 b3463000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b3473000 b347b000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b348b000 b34bb000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b34ce000 b3587000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b359b000 b35ee000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35ff000 b361a000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b362a000 b36eb000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36fe000 b370e000 r-xp /usr/lib/libefl-assist.so.0.1.0
b371e000 b372b000 r-xp /usr/lib/libmdm-common.so.1.0.98
b373c000 b3743000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b3753000 b3794000 r-xp /usr/lib/libmdm.so.1.2.12
b37a4000 b37ac000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b37bb000 b37cb000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37ec000 b384c000 r-xp /usr/lib/libasound.so.2.0.0
b385e000 b3861000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b3871000 b3874000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b3884000 b3889000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3899000 b389a000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b38aa000 b38b5000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b38c9000 b38d0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38e0000 b38e6000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38f6000 b38fb000 r-xp /usr/lib/libmmfsession.so.0.0.1
b390b000 b3926000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3936000 b393d000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b394d000 b3950000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b3961000 b398f000 r-xp /usr/lib/libidn.so.11.5.44
b399f000 b39b5000 r-xp /usr/lib/libnghttp2.so.5.4.0
b39c6000 b39d0000 r-xp /usr/lib/libcares.so.2.1.0
b39e0000 b39ea000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39fa000 b39fc000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b3a0c000 b3a0d000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3a1d000 b3a21000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b3a32000 b3a5a000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a6b000 b3a94000 r-xp /usr/lib/libturbojpeg.so
b3ab4000 b3aba000 r-xp /usr/lib/libgif.so.4.1.6
b3aca000 b3b10000 r-xp /usr/lib/libcurl.so.4.3.0
b3b21000 b3b42000 r-xp /usr/lib/libexif.so.12.3.3
b3b5d000 b3b72000 r-xp /usr/lib/libtts.so
b3b83000 b3b8b000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b9b000 b3c61000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c81000 b3d79000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d98000 b3e66000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e7d000 b3e7f000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e8f000 b3e95000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3ea5000 b3ec8000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ed9000 b3edb000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eeb000 b3eed000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3efe000 b3f03000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3f1a000 b3f1c000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3f2c000 b3f33000 r-xp /usr/lib/libsensord-share.so
b3f43000 b3f5b000 r-xp /usr/lib/libsensor.so.1.1.0
b3f6c000 b3f6f000 r-xp /usr/lib/libXv.so.1.0.0
b3f7f000 b3f84000 r-xp /usr/lib/libutilX.so.1.1.0
b3f94000 b3f99000 r-xp /usr/lib/libappcore-common.so.1.1
b3fa9000 b3fb0000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3fc3000 b3fc7000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fd8000 b40b6000 r-xp /usr/lib/libCOREGL.so.4.0
b40d6000 b40d9000 r-xp /usr/lib/libuuid.so.1.3.0
b40e9000 b4100000 r-xp /usr/lib/libblkid.so.1.1.0
b4111000 b4113000 r-xp /usr/lib/libXau.so.6.0.0
b4123000 b416a000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b417c000 b4182000 r-xp /usr/lib/libjson-c.so.2.0.1
b4193000 b4197000 r-xp /usr/lib/libogg.so.0.7.1
b41a7000 b41c9000 r-xp /usr/lib/libvorbis.so.0.4.3
b41d9000 b42bd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42d9000 b42dc000 r-xp /usr/lib/libEGL.so.1.4
b42ed000 b42f3000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4303000 b4305000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4315000 b4322000 r-xp /usr/lib/libGLESv2.so.2.0
b4333000 b4395000 r-xp /usr/lib/libpixman-1.so.0.28.2
b43aa000 b43c2000 r-xp /usr/lib/libmount.so.1.1.0
b43d4000 b43e8000 r-xp /usr/lib/libxcb.so.1.1.0
b43f8000 b43ff000 r-xp /lib/libcrypt-2.20-2014.11.so
b4437000 b4439000 r-xp /usr/lib/libiri.so
b4449000 b4454000 r-xp /usr/lib/libgpg-error.so.0.15.0
b4465000 b449b000 r-xp /usr/lib/libpulse.so.0.16.2
b44ac000 b44ef000 r-xp /usr/lib/libsndfile.so.1.0.25
b4504000 b4519000 r-xp /lib/libexpat.so.1.5.2
b452b000 b45e9000 r-xp /usr/lib/libcairo.so.2.11200.14
b45fd000 b4605000 r-xp /usr/lib/libdrm.so.2.4.0
b4615000 b4618000 r-xp /usr/lib/libdri2.so.0.0.0
b4628000 b4676000 r-xp /usr/lib/libssl.so.1.0.0
b468b000 b4697000 r-xp /usr/lib/libeeze.so.1.13.0
b46a8000 b46b1000 r-xp /usr/lib/libethumb.so.1.13.0
b46c1000 b46c4000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b46d4000 b488b000 r-xp /usr/lib/libcrypto.so.1.0.0
b5676000 b567f000 r-xp /usr/lib/libXi.so.6.1.0
b568f000 b5691000 r-xp /usr/lib/libXgesture.so.7.0.0
b56a1000 b56a5000 r-xp /usr/lib/libXtst.so.6.1.0
b56b5000 b56bb000 r-xp /usr/lib/libXrender.so.1.3.0
b56cb000 b56d1000 r-xp /usr/lib/libXrandr.so.2.2.0
b56e1000 b56e3000 r-xp /usr/lib/libXinerama.so.1.0.0
b56f4000 b56f7000 r-xp /usr/lib/libXfixes.so.3.1.0
b5707000 b5712000 r-xp /usr/lib/libXext.so.6.4.0
b5722000 b5724000 r-xp /usr/lib/libXdamage.so.1.1.0
b5734000 b5736000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5746000 b5828000 r-xp /usr/lib/libX11.so.6.3.0
b583c000 b5843000 r-xp /usr/lib/libXcursor.so.1.0.2
b5853000 b586b000 r-xp /usr/lib/libudev.so.1.6.0
b586d000 b5870000 r-xp /lib/libattr.so.1.1.0
b5880000 b58a0000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b58a1000 b58a6000 r-xp /usr/lib/libffi.so.6.0.2
b58b7000 b58cf000 r-xp /lib/libz.so.1.2.8
b58df000 b58e1000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58f1000 b59c6000 r-xp /usr/lib/libxml2.so.2.9.2
b59db000 b5a76000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a92000 b5a95000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5aa5000 b5abe000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5acf000 b5ae0000 r-xp /lib/libresolv-2.20-2014.11.so
b5af4000 b5b6e000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b83000 b5b85000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b95000 b5b9c000 r-xp /usr/lib/libembryo.so.1.13.0
b5bac000 b5bb6000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5bc7000 b5bdf000 r-xp /usr/lib/libpng12.so.0.50.0
b5bf0000 b5c13000 r-xp /usr/lib/libjpeg.so.8.0.2
b5c34000 b5c48000 r-xp /usr/lib/libector.so.1.13.0
b5c59000 b5c71000 r-xp /usr/lib/liblua-5.1.so
b5c82000 b5cd9000 r-xp /usr/lib/libfreetype.so.6.11.3
b5ced000 b5d15000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5d26000 b5d39000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d4a000 b5d84000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d95000 b5da3000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5db3000 b5dbb000 r-xp /usr/lib/libtbm.so.1.0.0
b5dcb000 b5dd8000 r-xp /usr/lib/libeio.so.1.13.0
b5de8000 b5dea000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dfa000 b5dff000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5e0f000 b5e26000 r-xp /usr/lib/libefreet.so.1.13.0
b5e38000 b5e58000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e68000 b5e88000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e8a000 b5e90000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5ea0000 b5eb1000 r-xp /usr/lib/libemotion.so.1.13.0
b5ec2000 b5ec9000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ed9000 b5ee8000 r-xp /usr/lib/libeo.so.1.13.0
b5ef9000 b5f0b000 r-xp /usr/lib/libecore_input.so.1.13.0
b5f1c000 b5f21000 r-xp /usr/lib/libecore_file.so.1.13.0
b5f31000 b5f4a000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f5a000 b5f77000 r-xp /usr/lib/libeet.so.1.13.0
b5f90000 b5fd8000 r-xp /usr/lib/libeina.so.1.13.0
b5fe9000 b5ff9000 r-xp /usr/lib/libefl.so.1.13.0
b600a000 b60ef000 r-xp /usr/lib/libicuuc.so.51.1
b610c000 b624c000 r-xp /usr/lib/libicui18n.so.51.1
b6263000 b629b000 r-xp /usr/lib/libecore_x.so.1.13.0
b62ad000 b62b0000 r-xp /lib/libcap.so.2.21
b62c0000 b62e9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62fa000 b6301000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b6313000 b634a000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b635b000 b6446000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6459000 b64d2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64e4000 b64e9000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64f9000 b6503000 r-xp /usr/lib/libvconf.so.0.2.45
b6513000 b6515000 r-xp /usr/lib/libvasum.so.0.3.1
b6525000 b6527000 r-xp /usr/lib/libttrace.so.1.1
b6537000 b653a000 r-xp /usr/lib/libiniparser.so.0
b654a000 b6570000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6580000 b6585000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6596000 b65ad000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b65be000 b6629000 r-xp /lib/libm-2.20-2014.11.so
b663a000 b6640000 r-xp /lib/librt-2.20-2014.11.so
b6651000 b665e000 r-xp /usr/lib/libunwind.so.8.0.1
b6694000 b67b8000 r-xp /lib/libc-2.20-2014.11.so
b67cd000 b67e6000 r-xp /lib/libgcc_s-4.9.so.1
b67f6000 b68d8000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68e9000 b6913000 r-xp /usr/lib/libdbus-1.so.3.8.12
b6924000 b6960000 r-xp /usr/lib/libsystemd.so.0.4.0
b6962000 b69e5000 r-xp /usr/lib/libedje.so.1.13.0
b69f8000 b6a16000 r-xp /usr/lib/libecore.so.1.13.0
b6a36000 b6bbd000 r-xp /usr/lib/libevas.so.1.13.0
b6bf2000 b6c06000 r-xp /lib/libpthread-2.20-2014.11.so
b6c1a000 b6e4e000 r-xp /usr/lib/libelementary.so.1.13.0
b6e7d000 b6e81000 r-xp /usr/lib/libsmack.so.1.0.0
b6e91000 b6e98000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6ea8000 b6eaa000 r-xp /usr/lib/libdlog.so.0.0.0
b6eba000 b6ebd000 r-xp /usr/lib/libbundle.so.0.1.22
b6ecd000 b6ecf000 r-xp /lib/libdl-2.20-2014.11.so
b6ee0000 b6ef8000 r-xp /usr/lib/libaul.so.0.1.0
b6f0c000 b6f11000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f22000 b6f2f000 r-xp /usr/lib/liblptcp.so
b6f41000 b6f45000 r-xp /usr/lib/libsys-assert.so
b6f56000 b6f76000 r-xp /lib/ld-2.20-2014.11.so
b6f87000 b6f8c000 r-xp /usr/bin/launchpad-loader
b7f88000 b81b3000 rw-p [heap]
bef32000 bef53000 rw-p [stack]
End of Maps Information

Callstack Information (PID:1532)
Call Stack Count: 13
 0: storage_get_root_directory + 0x1f (0xb337301c) [/usr/lib/libstorage.so.0.1] + 0x201c
 1: _ZN7MyLoginC2EP9Naviframe + 0x32 (0xb2806aab) [/opt/usr/apps/org.example.client/bin/client] + 0x3aab
 2: _ZN8MyWindow8onCreateEv + 0x110 (0xb28068f5) [/opt/usr/apps/org.example.client/bin/client] + 0x38f5
 3: _ZN6Window10app_createEPv + 0x8e (0xb280c4f7) [/opt/usr/apps/org.example.client/bin/client] + 0x94f7
 4: _ZN6Window17static_app_createEPv + 0x24 (0xb280c671) [/opt/usr/apps/org.example.client/bin/client] + 0x9671
 5: (0xb3fc54f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 6: appcore_efl_main + 0x152 (0xb6f0f203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 7: ui_app_main + 0xc0 (0xb3fc5909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
 8: _ZN6Window10makeWindowEiPPc + 0x11e (0xb280c9fb) [/opt/usr/apps/org.example.client/bin/client] + 0x99fb
 9: main + 0x40 (0xb280667d) [/opt/usr/apps/org.example.client/bin/client] + 0x367d
10: (0xb6f88bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
11: __libc_start_main + 0x114 (0xb66aa4bc) [/lib/libc.so.6] + 0x164bc
12: (0xb6f88eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
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
:05.823+0900 E/PKGMGR_SERVER( 7320): pm-mdm.c: _get_package_info_from_file(116) > [0;31m[_get_package_info_from_file(): 116](ret < 0) access() failed. path: org.example.client errno: 2 (No such file or directory)[0;m
04-02 23:39:05.823+0900 E/PKGMGR  ( 7318): pkgmgr.c: pkgmgr_client_reinstall(2133) > reinstall pkg finish, ret=[73180002]
04-02 23:39:06.044+0900 I/Tizen::App( 1256): (1894) > PackageEventHandler - req: 12560002, pkg_type: tpk, pkg_name: org.example.client, key: start, val: update
04-02 23:39:06.044+0900 I/Tizen::App( 1256): (1584) > Package = [org.example.client], Key = [start], Value = [update], install = [1]
04-02 23:39:06.054+0900 W/AUL_AMD (  596): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(1068) > __amd_pkgmgrinfo_start_handler
04-02 23:39:06.054+0900 I/Tizen::App( 1256): (1894) > PackageEventHandler - req: 12560002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 30
04-02 23:39:06.054+0900 I/Tizen::App( 1256): (119) > InstallationInProgress [30]
04-02 23:39:06.054+0900 I/Tizen::App( 1256): (1584) > Package = [org.example.client], Key = [install_percent], Value = [30], install = [1]
04-02 23:39:06.224+0900 W/CERT_SVC_VCORE( 7323): DUID.cpp: CheckCertifiedDevice(668) > No device id on distributor certificate
04-02 23:39:06.294+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_check_vip_tag(396) > (ret == 1) metadata(watchface) is empty.
04-02 23:39:06.294+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_get_value(1147) > (result_value == NULL) [ui-gadget] is empty.
04-02 23:39:06.304+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_append_path(335) > (ret == 1) NodeSet is empty. (//@portrait-effectimage)
04-02 23:39:06.304+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-02 23:39:06.304+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_allow_onboot(504) > (ret == 1) metadata is empty.
04-02 23:39:06.304+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_allow_autorestart(566) > (ret == 1) metadata is empty.
04-02 23:39:06.304+0900 E/PKGMGR_PARSER( 7323): pkgmgr_parser.c: pkgmgr_parser_check_manifest_validation(2678) > Manifest is Valid
04-02 23:39:06.314+0900 E/PKGMGR_PARSER( 7323): pkgmgr_parser_signature.c: __ps_check_mdm_policy(979) > (ret != MDM_RESULT_SUCCESS) can not connect mdm server
04-02 23:39:06.334+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(617) > Transaction Begin
04-02 23:39:06.344+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(622) > Certificate Deletion Success
04-02 23:39:06.344+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_delete_certinfo(635) > Transaction Commit and End
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: account_type_delete_by_app_id_offline(876) > [account_type_delete_by_app_id_offline:876] account_type_delete_by_app_id starting
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: account_type_delete_by_app_id_offline(882) > [account_type_delete_by_app_id_offline:882] client Id = [7323]
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: _account_db_open(66) > [_account_db_open:66] start to get DB path
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: _account_db_open(75) > [_account_db_open:75] account_db_path canonicalized = /opt/usr/dbspace/.account.db
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: account_type_delete_by_app_id_offline(899) > [account_type_delete_by_app_id_offline:899] before _account_type_delete_by_app_id
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: _account_get_record_count(216) > [_account_get_record_count:216] _account_get_record_count
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: _account_get_record_count(257) > [_account_get_record_count:257] account record count [0]
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: account_type_delete_by_app_id_offline(901) > [account_type_delete_by_app_id_offline:901] after _account_type_delete_by_app_id=[-16777213]
04-02 23:39:06.384+0900 E/ACCOUNT ( 7323): account_offline.c: account_type_delete_by_app_id_offline(905) > [account_type_delete_by_app_id_offline:905] _account_type_delete_by_app_id error
04-02 23:39:06.384+0900 I/ACCOUNT ( 7323): account_offline.c: account_type_delete_by_app_id_offline(910) > [account_type_delete_by_app_id_offline:910] account_type_delete_by_app_id_offline end
04-02 23:39:06.394+0900 I/PRIVACY-MANAGER-CLIENT( 7323): SocketClient.cpp: SocketClient(37) > Client created
04-02 23:39:06.444+0900 W/LOCKSCREEN(  844): dbus.c: _dbus_message_recv_cb(143) > [_dbus_message_recv_cb:143:W] PRE_LCD_ON cause[powerkey] (status:1)
04-02 23:39:06.444+0900 W/LOCKSCREEN(  844): event.c: _lcd_on_cb(54) > [_lcd_on_cb:54:W] Dbus LCD on
04-02 23:39:06.444+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:30001:LCD_ON
04-02 23:39:06.444+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:30001 event_info:0
04-02 23:39:06.444+0900 W/LOCKSCREEN(  844): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:3
04-02 23:39:06.444+0900 W/LOCKSCREEN(  844): daemon.c: _state_enter(378) > [_state_enter:378:W] PAUSE => WILL RESUME
04-02 23:39:06.444+0900 E/LOCKSCREEN(  844): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-02 23:39:06.454+0900 E/LOCKSCREEN(  844): control-panel-password.c: control_panel_password_update(136) > [control_panel_password_update:136:E] There is no control panel
04-02 23:39:06.454+0900 I/INDICATOR(  710): clock.c: indicator_clock_changed_cb(195) > ""
04-02 23:39:06.454+0900 E/UXT     (  710): uxt_util.c: uxt_util_get_date_time_text_by_locale(389) > text : 오후 11:39
04-02 23:39:06.454+0900 I/INDICATOR(  710): clock.c: getTimeFormatted(176) > "time format : 오후 11:39"
04-02 23:39:06.454+0900 I/INDICATOR(  710): clock.c: indicator_clock_changed_cb(244) > "time format : 오후 11:39"
04-02 23:39:06.454+0900 W/INDICATOR(  710): clock.c: indicator_clock_changed_cb(272) > 
04-02 23:39:06.454+0900 I/INDICATOR(  710): clock.c: indicator_clock_changed_cb(317) > "[CLOCK MODULE] Timer Status : -2146900875 Time: <font_size=31> </font_size> <font_size=31> 오후 11:39</font_size></font>"
04-02 23:39:06.474+0900 I/INDICATOR(  710): battery.c: show_battery_icon(376) > "Percentage:(0) / Level:(10) / batt_Full:(1) / battery_charging(0)"
04-02 23:39:06.474+0900 E/INDICATOR(  710): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-02 23:39:06.474+0900 E/INDICATOR(  710): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-02 23:39:06.474+0900 E/INDICATOR(  710): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-02 23:39:06.474+0900 E/INDICATOR(  710): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-02 23:39:06.474+0900 E/INDICATOR(  710): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-02 23:39:06.474+0900 E/INDICATOR(  710): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-02 23:39:06.664+0900 E/PKGMGR_PARSER( 7323): pkgmgr_parser.c: __check_theme(148) > theme for upgrade.
04-02 23:39:06.664+0900 E/rpm-installer( 7323): coretpk-parser.c: _coretpk_parser_is_svc_app(1031) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='service-application'])
04-02 23:39:06.664+0900 E/rpm-installer( 7323): coretpk-parser.c: __coretpk_parser_is_theme(31) > (ret == 1) metadata(watchface) is empty.
04-02 23:39:06.674+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
04-02 23:39:06.684+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 108
04-02 23:39:06.684+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 108
04-02 23:39:06.684+0900 W/LOCKSCREEN(  844): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:4
04-02 23:39:06.684+0900 W/LOCKSCREEN(  844): daemon.c: _state_enter(378) > [_state_enter:378:W] WILL RESUME => RESUME
04-02 23:39:06.684+0900 I/Tizen::App( 1256): (1894) > PackageEventHandler - req: 12560002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 60
04-02 23:39:06.684+0900 I/Tizen::App( 1256): (119) > InstallationInProgress [60]
04-02 23:39:06.684+0900 I/Tizen::App( 1256): (1584) > Package = [org.example.client], Key = [install_percent], Value = [60], install = [1]
04-02 23:39:06.684+0900 W/APP_CORE(  844): appcore-efl.c: __cmsg_cb(1034) > LCD On. Resume the topmost app
04-02 23:39:06.684+0900 I/APP_CORE(  844): appcore-efl.c: __do_app(514) > [APP 844] Event: RESUME State: PAUSED
04-02 23:39:06.684+0900 I/CAPI_APPFW_APPLICATION(  844): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-02 23:39:06.684+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20004:APP_RESUME
04-02 23:39:06.684+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:20004 event_info:0
04-02 23:39:06.684+0900 W/LOCKSCREEN(  844): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-02 23:39:06.684+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 41 2
04-02 23:39:06.684+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 31 3
04-02 23:39:06.684+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 32 3
04-02 23:39:06.684+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 42 2
04-02 23:39:06.694+0900 W/AUL     (  844): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-02 23:39:06.694+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 0
04-02 23:39:06.694+0900 W/AUL_AMD (  596): amd_launch.c: _start_app(2508) > caller pid : 844
04-02 23:39:06.694+0900 I/AUL_AMD (  596): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-02 23:39:06.704+0900 E/PKGMGR_CERT( 7323): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(576) > Transaction Commit and End
04-02 23:39:06.704+0900 W/AUL_AMD (  596): amd_launch.c: start_process(638) > child process: 7327
04-02 23:39:06.704+0900 E/RESOURCED(  712): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 23:39:06.744+0900 E/rpm-installer( 7323): installer-util.c: _installer_util_get_configuration_value(565) > [signature]=[on]
04-02 23:39:06.754+0900 W/AUL_AMD (  596): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7327
04-02 23:39:06.754+0900 W/AUL     (  596): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7327, appid: com.samsung.weather-m-agent
04-02 23:39:06.764+0900 I/Tizen::App( 1256): (499) > LaunchedApp(com.samsung.weather-m-agent)
04-02 23:39:06.764+0900 I/Tizen::App( 1256): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7327.
04-02 23:39:06.764+0900 W/AUL     (  844): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7327)
04-02 23:39:06.774+0900 E/rpm-installer( 7323): coretpk-parser.c: _coretpk_parser_is_widget(997) > (ret == 1) NodeSet is empty. (//*[name() = 'manifest']/*[name()='widget-application'])
04-02 23:39:06.794+0900 I/Tizen::App( 1256): (1894) > PackageEventHandler - req: 12560002, pkg_type: tpk, pkg_name: org.example.client, key: install_percent, val: 100
04-02 23:39:06.794+0900 I/Tizen::App( 1256): (119) > InstallationInProgress [100]
04-02 23:39:06.794+0900 I/Tizen::App( 1256): (1584) > Package = [org.example.client], Key = [install_percent], Value = [100], install = [96]
04-02 23:39:06.804+0900 I/Tizen::App( 1256): (1894) > PackageEventHandler - req: 12560002, pkg_type: tpk, pkg_name: org.example.client, key: end, val: ok
04-02 23:39:06.804+0900 I/Tizen::App( 1256): (78) > Installation is Completed. [Package = org.example.client]
04-02 23:39:06.804+0900 I/Tizen::App( 1256): (671) > Enter. package(org.example.client), installationResult(0)
04-02 23:39:06.814+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: OnClientListenCb(571) >  #Step 1
04-02 23:39:06.814+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: OnClientListenCb(575) >  #Step 2
04-02 23:39:06.814+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _GetAppIds(350) >  BEGIN
04-02 23:39:06.834+0900 W/ISF_PANEL_EFL(  784): isf_panel_efl.cpp: _package_manager_event_cb(1381) > isf_db_select_appids_by_pkgid returned 0.
04-02 23:39:06.834+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(253) >  ##### [org.example.client]
04-02 23:39:06.834+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _GetAppIds(375) >  ##### [org.example.client]
04-02 23:39:06.834+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _GetAppIds(379) >  END
04-02 23:39:06.834+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _DoPkgJob(458) >  #Step 3 size[1]
04-02 23:39:06.834+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _DoPkgJob(462) >  appId[org.example.client]
04-02 23:39:06.834+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _DoPkgJob(499) >  #9
04-02 23:39:06.844+0900 I/Tizen::App( 1256): (1360) > package(org.example.client), version(1.0.0), type(tpk), displayName(client), uninstallable(1), downloaded(1), updated(1), preloaded(0)movable(1), externalStorage(0), mainApp(org.example.client), storeClient(), appRootPath(/opt/usr/apps/org.example.client)
04-02 23:39:06.864+0900 I/Tizen::App( 1256): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.example.client]
04-02 23:39:06.875+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: _GetAppInfo(990) >  Name[client] enable[1] system[0]
04-02 23:39:06.875+0900 E/cluster-home(  861): mainmenu-package-manager.cpp: GetAppInfo(630) >  Find a App Info Name[client] enable[1] system[0]
04-02 23:39:06.875+0900 W/HOME_APPS(  861): mainmenu-box-impl.cpp: UpdateBoxData(1326) >  update box data!!!!! old icon path[/opt/usr/apps/org.example.client/shared/res/client.png], New icon path[/opt/usr/apps/org.example.client/shared/res/client.png]!!!!!
04-02 23:39:06.885+0900 I/Tizen::App( 1256): (416) > appName = [client]
04-02 23:39:06.885+0900 I/Tizen::App( 1256): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-02 23:39:06.885+0900 E/PKGMGR_INFO( 1256): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(887) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
04-02 23:39:06.885+0900 I/Tizen::App( 1256): (683) > Application count(1) in this package
04-02 23:39:06.885+0900 I/Tizen::App( 1256): (840) > Enter.
04-02 23:39:06.885+0900 I/Tizen::App( 1256): (703) > Exit.
04-02 23:39:06.885+0900 I/Tizen::App( 1256): (1584) > Package = [org.example.client], Key = [end], Value = [ok], install = [96]
04-02 23:39:06.905+0900 E/util-view(  861): util-text-image-provider.cpp: GetPixelsFromText(240) >  DEFAULT='font=SamsungOneUI:style=Regular style=shadow,bottom shadow_color=# font_size=28 align=center valign=top color=#FFFFFF color_class=ATO001 text_class=ATO001 ellipsis=1 wrap=mixed linegap=-3'
04-02 23:39:06.915+0900 I/Tizen::App( 1256): (416) > appName = [client]
04-02 23:39:06.915+0900 I/Tizen::App( 1256): (509) > exe = [/opt/usr/apps/org.example.client/bin/client], displayName = [client], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
04-02 23:39:06.915+0900 I/Tizen::App( 1256): (2343) > info file is not existed. [/opt/usr/apps/org.exampl/info/org.example.client.info]
04-02 23:39:06.915+0900 I/Tizen::App( 1256): (131) > Enter
04-02 23:39:06.915+0900 I/Tizen::App( 1256): (137) > org.example.client does not have launch condition
04-02 23:39:06.915+0900 I/Tizen::App( 1256): (883) > Exit.
04-02 23:39:06.995+0900 E/weather-agent( 7327): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.lockscreen, portId:lockscreen-message-port, message:GET_DISPLAY_CITY_WEATHER_INFO[0;m
04-02 23:39:06.995+0900 E/weather-common( 7327): ShareTargetDBController.cpp: Insert(138) > [0;40;31mThere is a same appId. so we didn't insert this app[0;m
04-02 23:39:07.005+0900 E/weather-agent( 7327): AgentMain.cpp: AppControl(232) > [0;40;31mAppID : com.samsung.lockscreen, PortID : lockscreen-message-port[0;m
04-02 23:39:07.015+0900 I/MESSAGE_PORT( 7327): message-port.c: __initialize(872) > initialize
04-02 23:39:07.025+0900 I/MESSAGE_PORT( 7327): message-port.c: __initialize(878) > init : com.samsung.weather-m-agent
04-02 23:39:07.085+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-02 23:39:07.085+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-02 23:39:07.085+0900 I/MESSAGE_PORT( 7327): message-port.c: __message_port_send_message(972) > port exist check !!
04-02 23:39:07.085+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.lockscreen:lockscreen-message-port]
04-02 23:39:07.085+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.lockscreen : com.samsung.weather-m-agent] 
04-02 23:39:07.085+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080 
04-02 23:39:07.095+0900 I/Tizen::System( 1256): (280) > The screen has been turned on.
04-02 23:39:07.095+0900 I/Tizen::Io( 1256): (729) > Entry not found
04-02 23:39:07.115+0900 W/LOCKSCREEN(  844): dbus.c: _dbus_message_recv_cb(154) > [_dbus_message_recv_cb:154:W] POST_LCD_ON status 2 visibility(1)
04-02 23:39:07.115+0900 E/weather-widget( 1292): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-02 23:39:07.125+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-02 23:39:07.125+0900 I/Tizen::System( 1256): (157) > change brightness system value.
04-02 23:39:07.125+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(613) > [0;40;31mmessage_port_send_message success [com.samsung.lockscreen, lockscreen-message-port][0;m
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __message_port_send_message(972) > port exist check !!
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m:com.samsung.weather-m.message.port.local]
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m : com.samsung.weather-m-agent] 
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860 
04-02 23:39:07.135+0900 E/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._1084d0029f1b28c114e74533f03fc7860
04-02 23:39:07.135+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(641) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m, com.samsung.weather-m.message.port.local][0;m
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __message_port_send_message(972) > port exist check !!
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget:com.samsung.weather-m-widget.message.port.local]
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget : com.samsung.weather-m-agent] 
04-02 23:39:07.135+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0 
04-02 23:39:07.135+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-02 23:39:07.135+0900 I/MESSAGE_PORT(  844): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(632) > Exist port: org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-02 23:39:07.145+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 15
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __message_port_send_message(972) > port exist check !!
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(544) > Check a remote port : [com.samsung.weather-m-widget-setting:com.samsung.weather-m-widget-setting.message.port.local]
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(556) > remote_app_id, app_id :[com.samsung.weather-m-widget-setting : com.samsung.weather-m-agent] 
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: __get_encoded_name(162) > encoded_bus_name : org.tizen.messageport._a368d541df9b0d6392147558484f54160 
04-02 23:39:07.145+0900 E/MESSAGE_PORT( 7327): message-port.c: __check_remote_port(602) > Name not exist org.tizen.messageport._a368d541df9b0d6392147558484f54160
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(648) > [0;40;31mmessage_port_send_message failed [com.samsung.weather-m-widget-setting, com.samsung.weather-m-widget-setting.message.port.local][0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(652) > [0;40;31mresult : 0[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(653) > [0;40;31mCityName : 흑석동[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(654) > [0;40;31mCityNameEng : Heukseok-dong[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(655) > [0;40;31mCurrentTemperature : 4.000000[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(656) > [0;40;31mHighTemperature : 14.300000[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(657) > [0;40;31mLowTemperature : 35.800000[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(658) > [0;40;31mIconID : 18[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(659) > [0;40;31mRefreshedTime : 1491068922[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(661) > [0;40;31mSettingTemperatureUnit : c[0;m
04-02 23:39:07.145+0900 E/weather-common( 7327): WeatherInformationShareUtil.cpp: SendBundleViaMessagePort(662) > [0;40;31mSettingShowCurrentCity : On[0;m
04-02 23:39:07.145+0900 E/weather-agent( 7327): AgentMain.cpp: StartServiceTerminateTimer(119) > [0;40;31mthere is same appControl. we should erase it from mAgentControllerPtrVector[0;m
04-02 23:39:07.145+0900 E/weather-agent( 7327): AgentMain.cpp: StartServiceTerminateTimer(137) > [0;40;31mStart ServiceTerminateTimer. Wait ...[0;m
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._98320b4a4b8bbb405aaba1ec51c348080
04-02 23:39:07.145+0900 I/MESSAGE_PORT( 7327): message-port.c: on_name_appeared(244) > name appeared : com.samsung.weather-m-agent org.tizen.messageport._2c85dcff3f047c2c60c1caf049522b1f0
04-02 23:39:07.155+0900 E/weather-common( 1292): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-02 23:39:07.205+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_create(409) > New handle created[0xb7780448]
04-02 23:39:07.205+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_get_type(463) > Connected Network = 2
04-02 23:39:07.205+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_destroy(427) > Destroy handle: 0xb7780448
04-02 23:39:07.205+0900 E/weather-common( 1292): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-02 23:39:07.215+0900 E/weather-widget( 1292): WidgetMain.cpp: ResumeWidgetInstance(653) > [0;40;31mecore_timer_add. AutoRefreshTimerCb will be called after 1 sec[0;m
04-02 23:39:07.215+0900 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-02 23:39:07.215+0900 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-02 23:39:07.215+0900 W/AUL     ( 1292): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1292, appid: com.samsung.weather-m-widget, status: fg
04-02 23:39:07.215+0900 I/MESSAGE_PORT( 1292): message-port.c: __dbus_method_call_handler(672) > method_name: send_message
04-02 23:39:07.215+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 15
04-02 23:39:07.255+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 15
04-02 23:39:07.265+0900 E/EFL     (  844): ecore_x<844> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=75014367
04-02 23:39:07.315+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-02 23:39:07.315+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-02 23:39:07.535+0900 E/EFL     (  844): ecore_x<844> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=75014645
04-02 23:39:07.535+0900 E/LOCKSCREEN(  844): progress_circle.c: unlock_mouse_up(425) > [unlock_mouse_up:425:E] 
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80001:VIEW_GESTURED
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:80001 event_info:0
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): view-mgr.c: _event_route(130) > [_event_route:130:W] event:80001 event_info:0
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): view-mgr.c: _state_transit(46) > [_state_transit:46:W] state transit:2
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): view-mgr.c: _state_transit(49) > [_state_transit:49:W] already in same state:2
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:4:LKD_EVT_WILL_UNLOCK
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:4 event_info:0
04-02 23:39:07.535+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event_delay(1041) > [lockd_event_delay:1041:W] dealyed event:2:UNLOCK wait for:0.330000
04-02 23:39:07.535+0900 E/LOCKSCREEN(  844): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-02 23:39:07.595+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_create(409) > New handle created[0xb780d928]
04-02 23:39:07.595+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_get_type(463) > Connected Network = 2
04-02 23:39:07.595+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_destroy(427) > Destroy handle: 0xb780d928
04-02 23:39:07.595+0900 E/weather-common( 1292): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-02 23:39:07.595+0900 W/LOCATION( 1292): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
04-02 23:39:07.595+0900 E/weather-common( 1292): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
04-02 23:39:07.625+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
04-02 23:39:07.625+0900 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __provider_update_cb(287) > received updating signal
04-02 23:39:07.645+0900 E/EFL     ( 1292): edje<1292> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-02 23:39:07.665+0900 E/EFL     ( 1292): evas_main<1292> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800d329d is not stable during recalc loop
04-02 23:39:07.715+0900 E/EFL     ( 1292): evas_main<1292> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800d329d is not stable during recalc loop
04-02 23:39:07.725+0900 E/EFL     ( 1292): edje<1292> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-02 23:39:07.735+0900 E/cluster-home(  861): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
04-02 23:39:07.745+0900 W/cluster-view(  861): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-02 23:39:07.865+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:2 event_info:0
04-02 23:39:07.865+0900 W/LOCKSCREEN(  844): daemon.c: _state_transit(446) > [_state_transit:446:W] state transit:7
04-02 23:39:07.865+0900 W/LOCKSCREEN(  844): daemon.c: _state_enter(378) > [_state_enter:378:W] RESUME => HIDE
04-02 23:39:07.865+0900 E/LOCKSCREEN(  844): complex-password.c: complex_password_unfocus_entry(155) > [complex_password_unfocus_entry:155:E] (s_complex_password_info.entry == NULL) -> complex_password_unfocus_entry() return
04-02 23:39:07.865+0900 E/LOCKSCREEN(  844): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-02 23:39:07.865+0900 E/LOCKSCREEN(  844): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-02 23:39:07.865+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-02 23:39:07.865+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-02 23:39:07.865+0900 W/LOCKSCREEN(  844): daemon.c: _lcd_timeout_timer_set(724) > [_lcd_timeout_timer_set:724:W] lcd off timer set:30.000000
04-02 23:39:07.875+0900 E/EFL     (  345): eo<345> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-02 23:39:07.875+0900 I/APP_CORE(  861): appcore-efl.c: __do_app(514) > [APP 861] Event: RESUME State: PAUSED
04-02 23:39:07.875+0900 I/CAPI_APPFW_APPLICATION(  861): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-02 23:39:07.875+0900 E/cluster-home(  861): homescreen.cpp: OnResume(233) >  app resume
04-02 23:39:07.885+0900 W/AUL_AMD (  596): amd_launch.c: __e17_status_handler(3328) > pid(844) status(4)
04-02 23:39:07.885+0900 W/AUL     (  596): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.lockscreen(844)
04-02 23:39:07.885+0900 W/AUL     (  596): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 844, appid: com.samsung.lockscreen, status: bg
04-02 23:39:07.885+0900 W/LOCKSCREEN(  844): lockscreen.c: _window_visibility_cb(344) > [_window_visibility_cb:344:W] Window [0x2E00007] is [invisible]
04-02 23:39:07.885+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:10002:WIN_BECOME_INVISIBLE
04-02 23:39:07.885+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:10002 event_info:0
04-02 23:39:07.885+0900 E/EFL     (  345): eo<345> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-02 23:39:07.895+0900 E/PKGMGR_SERVER( 7320): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=0, queue_status=1, drm_status=1] 
04-02 23:39:07.895+0900 E/LOCKSCREEN(  844): util-daemon.c: _lock_state_timer_cb(56) > [_lock_state_timer_cb:56:E] ########## LOCK STATE SET : VCONFKEY_IDLE_UNLOCK ##########
04-02 23:39:07.895+0900 I/APP_CORE(  844): appcore-efl.c: __do_app(514) > [APP 844] Event: PAUSE State: RUNNING
04-02 23:39:07.895+0900 I/CAPI_APPFW_APPLICATION(  844): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-02 23:39:07.895+0900 E/LOCKSCREEN(  844): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-02 23:39:07.895+0900 E/LOCKSCREEN(  844): emergency-call.c: emergency_call_action(166) > [emergency_call_action:166:E] (view == NULL) -> emergency_call_action() return
04-02 23:39:07.895+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:20002:APP_PAUSE
04-02 23:39:07.895+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:20002 event_info:0
04-02 23:39:07.895+0900 W/LOCKSCREEN(  844): daemon.c: _lcd_timeout_timer_unset(733) > [_lcd_timeout_timer_unset:733:W] lcd off timer unset
04-02 23:39:07.895+0900 E/LOCKSCREEN(  844): dbus_util.c: _lockscreen_set_bg(275) > [_lockscreen_set_bg:275:E] Sending LockScreenBgOn signal result:0
04-02 23:39:07.906+0900 W/AUL_AMD (  596): amd_launch.c: __e17_status_handler(3328) > pid(861) status(3)
04-02 23:39:07.906+0900 W/AUL_AMD (  596): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-02 23:39:07.906+0900 W/AUL_AMD (  596): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-02 23:39:07.906+0900 W/AUL     (  596): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(861)
04-02 23:39:07.906+0900 W/AUL     (  596): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 861, appid: com.samsung.homescreen, status: fg
04-02 23:39:07.906+0900 W/HOME_APPS(  861): mainmenu-box-impl.cpp: _OnImageLoadFinishedHandler(2152) >  finished path[/opt/usr/apps/org.example.client/shared/res/client.png], Loading state:[1]
04-02 23:39:07.916+0900 I/APP_CORE(  844): appcore-efl.c: __do_app(514) > [APP 844] Event: MEM_FLUSH State: PAUSED
04-02 23:39:07.926+0900 I/Tizen::System( 1256): (259) > Active app [com.samsun], current [com.samsun] 
04-02 23:39:07.926+0900 I/Tizen::System( 1256): (273) > Current App[com.samsun] is already actived.
04-02 23:39:07.936+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 15
04-02 23:39:07.996+0900 W/LOCKSCREEN(  844): view-mgr.c: _event_route(130) > [_event_route:130:W] event:2 event_info:0
04-02 23:39:07.996+0900 E/LOCKSCREEN(  844): contextual-info.c: contextual_info_effect_notification(1545) > [contextual_info_effect_notification:1545:E] (s_contextual_info.ly_page_noti == NULL) -> contextual_info_effect_notification() return
04-02 23:39:07.996+0900 E/LOCKSCREEN(  844): default-unlock.c: default_unlock_hide_on_noti_tapped(821) > Failed to get selected noti
04-02 23:39:07.996+0900 W/LOCKSCREEN(  844): daemon.c: lockd_event(1028) > [lockd_event:1028:W] event:80000:VIEW_IDLE
04-02 23:39:07.996+0900 W/LOCKSCREEN(  844): daemon.c: _event_route(838) > [_event_route:838:W] event:80000 event_info:0
04-02 23:39:08.006+0900 E/LOCKSCREEN(  844): background-view.c: background_image_next_set(321) > [background_image_next_set:321:E] fopen wallpaper txt file failed.
04-02 23:39:08.146+0900 E/weather-agent( 7327): AgentMain.cpp: TerminateService(89) > [0;40;31mTerminateService[0;m
04-02 23:39:08.146+0900 I/CAPI_APPFW_APPLICATION( 7327): service_app_main.c: service_app_exit(446) > service_app_exit
04-02 23:39:08.156+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 22
04-02 23:39:08.156+0900 E/weather-agent( 7327): AgentMain.cpp: AppTerminate(178) > [0;40;31mAppTerminate[0;m
04-02 23:39:08.156+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(1201) > app status : 5
04-02 23:39:08.216+0900 E/weather-widget( 1292): WidgetMain.cpp: AutoRefreshTimerCb(329) > [0;40;31mAutoRefreshTimerCb[0;m
04-02 23:39:08.216+0900 W/AUL     ( 1292): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-02 23:39:08.216+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 0
04-02 23:39:08.216+0900 W/AUL_AMD (  596): amd_launch.c: _start_app(2508) > caller pid : 1292
04-02 23:39:08.216+0900 I/AUL_AMD (  596): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-02 23:39:08.226+0900 W/AUL     (  596): app_signal.c: aul_send_app_resume_request_signal(468) > send_app_resume_signal, pid: 7327, appid: com.samsung.weather-m-agent
04-02 23:39:08.226+0900 W/AUL_AMD (  596): amd_launch.c: __nofork_processing(1412) > __nofork_processing, cmd: 0, pid: 7327
04-02 23:39:08.226+0900 W/AUL     ( 1292): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7327)
04-02 23:39:08.226+0900 E/weather-widget( 1292): WidgetMain.cpp: SetIsNowRefreshing(208) > [0;40;31mSetIsNowRefreshing as:1[0;m
04-02 23:39:08.236+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 15
04-02 23:39:08.276+0900 W/AUL     ( 1292): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.weather-m-agent)
04-02 23:39:08.276+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 0
04-02 23:39:08.276+0900 W/AUL_AMD (  596): amd_launch.c: _start_app(2508) > caller pid : 1292
04-02 23:39:08.276+0900 I/AUL_AMD (  596): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-02 23:39:08.286+0900 W/AUL_AMD (  596): amd_launch.c: start_process(638) > child process: 7368
04-02 23:39:08.286+0900 E/RESOURCED(  712): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 23:39:08.336+0900 W/AUL_AMD (  596): amd_launch.c: __send_app_launch_signal(411) > send launch signal done: 7368
04-02 23:39:08.336+0900 W/AUL     (  596): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 7368, appid: com.samsung.weather-m-agent
04-02 23:39:08.346+0900 I/Tizen::App( 1256): (499) > LaunchedApp(com.samsung.weather-m-agent)
04-02 23:39:08.346+0900 I/Tizen::App( 1256): (733) > Finished invoking application event listener for com.samsung.weather-m-agent, 7368.
04-02 23:39:08.356+0900 W/AUL     ( 1292): launch.c: app_request_to_launchpad(425) > request cmd(0) result(7368)
04-02 23:39:08.356+0900 W/AUL_AMD (  596): amd_request.c: __send_app_termination_signal(609) > send dead signal done
04-02 23:39:08.356+0900 E/AUL_AMD (  596): amd_launch.c: __reply_handler(1059) > recv error : Connection reset by peer
04-02 23:39:08.356+0900 E/AUL_AMD (  596): amd_launch.c: __real_send(993) > send fail to client: -70
04-02 23:39:08.356+0900 W/AUL_AMD (  596): amd_launch.c: __reply_handler(1083) > listen fd(32) , send fd(31), pid(7327), cmd(0)
04-02 23:39:08.366+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 7327
04-02 23:39:08.366+0900 W/AUL_AMD (  596): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 7327
04-02 23:39:08.366+0900 I/Tizen::App( 1256): (243) > App[com.samsung.weather-m-agent] pid[7327] terminate event is forwarded
04-02 23:39:08.366+0900 I/Tizen::System( 1256): (256) > osp.accessorymanager.service provider is found.
04-02 23:39:08.366+0900 I/Tizen::System( 1256): (196) > Accessory Owner is removed [com.samsung.weather-m-agent, 7327, ]
04-02 23:39:08.366+0900 I/Tizen::System( 1256): (256) > osp.system.service provider is found.
04-02 23:39:08.366+0900 I/Tizen::App( 1256): (506) > TerminatedApp(com.samsung.weather-m-agent)
04-02 23:39:08.366+0900 I/Tizen::App( 1256): (512) > Not registered pid(7327)
04-02 23:39:08.366+0900 I/Tizen::System( 1256): (246) > Terminated app [com.samsung.weather-m-agent]
04-02 23:39:08.366+0900 I/Tizen::Io( 1256): (729) > Entry not found
04-02 23:39:08.376+0900 I/Tizen::System( 1256): (157) > change brightness system value.
04-02 23:39:08.376+0900 I/Tizen::App( 1256): (782) > Finished invoking application event listener for com.samsung.weather-m-agent, 7327.
04-02 23:39:08.376+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(458) > [0;40;31mUpdate City Information on Widget[0;m
04-02 23:39:08.376+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(461) > [0;40;31mmCenterPageControllerPtr resume start[0;m
04-02 23:39:08.536+0900 W/CAPI_APPFW_APP_CONTROL( 7368): app_control.c: app_control_error(152) > [app_control_get_extra_data] KEY_NOT_FOUND(0xffffff82)
04-02 23:39:08.536+0900 E/weather-agent( 7368): AgentMain.cpp: AppControl(208) > [0;40;31mapp_control_get_extra_data(portId) failed[0;m
04-02 23:39:08.536+0900 E/weather-agent( 7368): AgentMain.cpp: AppControl(214) > [0;40;31mappId:com.samsung.weather-m-widget, portId:(null), message:REQUEST_ALL_WEATHER_INFO[0;m
04-02 23:39:08.536+0900 E/weather-common( 7368): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-02 23:39:08.546+0900 E/weather-common( 7368): CityDBController.cpp: GetLocationIdOfCurrentCity(649) > [0;40;31mNo result : 101[0;m
04-02 23:39:08.576+0900 E/weather-common( 7368): APIUrlGenerator.cpp: GetCurrentLanguageAccuWeather(195) > [0;40;31mVCONFKEY_LANGSET : ko_KR.UTF-8[0;m
04-02 23:39:08.576+0900 E/weather-common( 7368): APIUrlGenerator.cpp: GetCurrentLanguageAccuWeather(201) > [0;40;31mlanguageCode ko[0;m
04-02 23:39:08.646+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_create(409) > New handle created[0xb7769638]
04-02 23:39:08.646+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_get_type(463) > Connected Network = 2
04-02 23:39:08.646+0900 I/CAPI_NETWORK_CONNECTION( 1292): connection.c: connection_destroy(427) > Destroy handle: 0xb7769638
04-02 23:39:08.646+0900 E/weather-common( 1292): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-02 23:39:08.646+0900 W/LOCATION( 1292): location.c: location_is_enabled_method(303) > [SECURE_LOG] [db/location/setting/Usemylocation]:[0]
04-02 23:39:08.646+0900 E/weather-common( 1292): Location.cpp: IsLocationAvailable(282) > [0;40;31menabled : 0[0;m
04-02 23:39:08.656+0900 I/CAPI_NETWORK_CONNECTION( 7368): connection.c: connection_create(409) > New handle created[0xb76983d8]
04-02 23:39:08.666+0900 E/weather-widget( 1292): WidgetView.cpp: Resume(465) > [0;40;31mmCenterPageControllerPtr resume end[0;m
04-02 23:39:08.676+0900 I/CAPI_WIDGET_APPLICATION( 1292): widget_app.c: __provider_update_cb(287) > received updating signal
04-02 23:39:08.676+0900 E/EFL     ( 1292): edje<1292> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-02 23:39:08.696+0900 E/EFL     ( 1292): evas_main<1292> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800f93cd is not stable during recalc loop
04-02 23:39:08.736+0900 E/EFL     ( 1292): evas_main<1292> lib/evas/canvas/evas_object_smart.c:960 _evas_object_smart_need_recalculate_set() Object 0x800f93cd is not stable during recalc loop
04-02 23:39:08.736+0900 E/EFL     ( 1292): edje<1292> lib/edje/edje_util.c:3568 _edje_object_size_min_restricted_calc() file /usr/apps/com.samsung.weather-m/res/contents/MDPI/edje/widget/Widget4x4Page.edj, group city has a non-fixed part 'localTime'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
04-02 23:39:08.756+0900 E/cluster-home(  861): cluster-data-list.cpp: GetDBoxID(1000) >  found id[5]
04-02 23:39:08.756+0900 W/cluster-view(  861): custom-box-impl.cpp: SetZeroPageBoxDimEffect(4542) >  This is not zero page box [0]
04-02 23:39:08.776+0900 E/weather-common( 7368): Engine.cpp: OnHttpResponseCompleted(516) > [0;40;31mREQ_TYPE_GET_WEATHER_INFO_WITH_LOCATION_ID[0;m
04-02 23:39:08.816+0900 E/weather-common( 7368): APIUrlGenerator.cpp: GetCurrentLanguageAccuWeather(195) > [0;40;31mVCONFKEY_LANGSET : ko_KR.UTF-8[0;m
04-02 23:39:08.816+0900 E/weather-common( 7368): APIUrlGenerator.cpp: GetCurrentLanguageAccuWeather(201) > [0;40;31mlanguageCode ko[0;m
04-02 23:39:08.816+0900 I/CAPI_NETWORK_CONNECTION( 7368): connection.c: connection_create(409) > New handle created[0xb76517f8]
04-02 23:39:08.826+0900 E/weather-common( 7368): CurlNetworkConnection.cpp: SGIOPipeWatchCB(832) > [0;40;31mthere is no message in the pipe, ret:-1[0;m
04-02 23:39:09.147+0900 W/AUL     ( 7397): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-02 23:39:09.147+0900 W/AUL_AMD (  596): amd_request.c: __request_handler(906) > __request_handler: 0
04-02 23:39:09.157+0900 I/AUL     (  596): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-02 23:39:09.157+0900 I/AUL     (  596): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-02 23:39:09.157+0900 E/AUL_AMD (  596): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-02 23:39:09.157+0900 W/AUL_AMD (  596): amd_launch.c: _start_app(2508) > caller pid : 7397
04-02 23:39:09.157+0900 E/AUL_AMD (  596): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-02 23:39:09.167+0900 E/RESOURCED(  712): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 3
04-02 23:39:09.167+0900 E/RESOURCED(  712): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-02 23:39:09.177+0900 W/AUL_AMD (  596): amd_launch.c: _start_app(3052) > pad pid(-5)
04-02 23:39:09.177+0900 W/AUL_PAD ( 1531): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-02 23:39:09.177+0900 W/AUL_PAD ( 1531): launchpad.c: __send_result_to_caller(267) > Check app launching
04-02 23:39:09.187+0900 I/abc     ( 1532): abc
04-02 23:39:09.187+0900 I/CAPI_APPFW_APPLICATION( 1532): app_main.c: ui_app_main(789) > app_efl_main
04-02 23:39:09.187+0900 I/CAPI_APPFW_APPLICATION( 1532): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-02 23:39:09.217+0900 E/TBM     ( 1532): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-02 23:39:09.227+0900 E/PKGMGR_SERVER( 7320): pkgmgr-server.c: sighandler(417) > child NORMAL exit [7323]
04-02 23:39:09.277+0900 W/AUL     (  596): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 1532, appid: org.example.client
04-02 23:39:09.277+0900 E/AUL     (  596): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-02 23:39:09.277+0900 W/AUL     ( 7397): launch.c: app_request_to_launchpad(425) > request cmd(0) result(1532)
04-02 23:39:09.557+0900 W/CRASH_MANAGER( 7412): worker.c: worker_job(1199) > 1101532636c69149114394
